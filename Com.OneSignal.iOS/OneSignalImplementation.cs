using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Com.OneSignal.Core;
using Com.OneSignal.iOS;
using Foundation;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;


namespace Com.OneSignal {
   public partial class OneSignalImplementation : OneSignalSDK {
      public LogType currentLogLevel;
      public LogType currentAlertLevel;

      public override event NotificationWillShowDelegate NotificationWillShow;
      public override event NotificationActionDelegate NotificationWasOpened;
      public override event InAppMessageLifecycleDelegate InAppMessageWillDisplay;
      public override event InAppMessageLifecycleDelegate InAppMessageDidDisplay;
      public override event InAppMessageLifecycleDelegate InAppMessageWillDismiss;
      public override event InAppMessageLifecycleDelegate InAppMessageDidDismiss;
      public override event InAppMessageActionDelegate InAppMessageTriggeredAction;
      public override event StateChangeDelegate<PermissionState> PermissionStateChanged;
      public override event StateChangeDelegate<PushSubscriptionState> PushSubscriptionStateChanged;
      public override event StateChangeDelegate<EmailSubscriptionState> EmailSubscriptionStateChanged;
      public override event StateChangeDelegate<SMSSubscriptionState> SMSSubscriptionStateChanged;

      public override void Initialize(string appId) {
         Console.WriteLine("App Initialization");
         InitWithLaunchOptions();
         OneSignalNative.AppId = appId;
      }

      private void InitWithLaunchOptions() {
         OneSignalNative.InitWithLaunchOptions(null);
      }

      public override bool PrivacyConsent {
         get => false;
         set => OneSignalNative.ConsentGranted(value);
      }

      public override bool RequiresPrivacyConsent {
         get => OneSignalNative.RequiresUserPrivacyConsent();
         set => OneSignalNative.SetRequiresUserPrivacyConsent(value);
      }

      public override async Task<NotificationPermission> PromptForPushNotificationsWithUserResponse() {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.PromptForPushNotificationsWithUserResponse(response => proxy.OnResponse(true));
         return await proxy ? NotificationPermission.Authorized : NotificationPermission.Denied;
      }

      public override LogType LogLevel {
         get => currentLogLevel;
         set {
            currentLogLevel = value;
            OneSignalNative.SetLogLevel((OneSLogLevel)currentLogLevel, (OneSLogLevel)currentAlertLevel);
         }
      }

      public override LogType AlertLevel {
         get => currentAlertLevel;
         set {
            currentAlertLevel = value;
            OneSignalNative.SetLogLevel((OneSLogLevel)currentLogLevel, (OneSLogLevel)currentAlertLevel);
         }
      }

      public override async Task<bool> SetSMSNumber(string smsNumber, string authHash = null) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SetSMSNumber(smsNumber, authHash, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }


      public override async Task<bool> SetEmail(string email, string authHash = null) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SetEmail(email, authHash,
             delegate { proxy.OnResponse(true); }, response => proxy.OnResponse(false));
         return await proxy;
      }

      public override async Task<bool> RemoveExternalUserId() {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.RemoveExternalUserId(response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override async Task<bool> LogoutEmail() {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.LogoutEmailWithSuccess(delegate { proxy.OnResponse(true); }, delegate { proxy.OnResponse(false); });
         return await proxy;
      }

      public override async Task<bool> LogoutSMS() {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.LogoutSMSNumberWithSuccess(response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override void SetLanguage(string language) {
         OneSignalNative.SetLanguage(language);
      }

      public override async Task<bool> SetExternalUserId(string externalId, string authHash = null) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SetExternalUserId(externalId, authHash, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override void SendTag(string key, string value) {
         OneSignalNative.SendTag(key, value);
      }

      public override async Task<bool> SendTags(Dictionary<string, object> tags) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SendTags(NativeConversion.DictToNSDict(tags), response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override async Task<Dictionary<string, object>> GetTags() {
         DictionaryCallbackProxy proxy = new DictionaryCallbackProxy();
         OneSignalNative.GetTags(response => proxy.OnResponse(NativeConversion.NSDictToPureDict(response)));
         return await proxy;
      }

      public override async Task<bool> DeleteTag(string key) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.DeleteTag(key, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override async Task<bool> DeleteTags(params string[] keys) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         int count = 0;

         foreach (var key in keys) {
            count++;
         }
         NSObject[] nsKeys = new NSObject[count];
         count = 0;
         foreach (var key in keys) {
            nsKeys[count] = NSString.FromData(key, NSStringEncoding.UTF8);
         }

         OneSignalNative.DeleteTags(nsKeys, response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override async Task<bool> PostNotification(Dictionary<string, object> options) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.PostNotification(NativeConversion.DictToNSDict(options), response => proxy.OnResponse(true), response => proxy.OnResponse(false));
         return await proxy;
      }

      public override bool ShareLocation {
         get => OneSignalNative.IsLocationShared();
         set => OneSignalNative.SetLocationShared(value);
      }

      public override void PromptLocation() {
         OneSignalNative.PromptLocation();
      }

      public override void ClearOneSignalNotifications() {
         throw new NotImplementedException();
      }

      public override void SetTrigger(string key, object triggerObject) {
         OneSignalNative.AddTrigger(key, (NSObject)triggerObject);
      }

      public override void SetTriggers(Dictionary<string, object> triggers) {
         NSMutableDictionary<NSString, NSObject> triggersDictionary = new NSMutableDictionary<NSString, NSObject>();
         foreach (var trigger in triggers) {
            triggersDictionary.Add(
                NSString.FromData(trigger.Key, NSStringEncoding.UTF8),
                NSObject.FromObject(trigger.Value));
         }
         OneSignalNative.AddTriggers(NSDictionary.FromDictionary(triggersDictionary));
      }

      public override void RemoveTrigger(string key) {
         OneSignalNative.RemoveTriggerForKey(key);
      }

      public override void RemoveTriggers(params string[] keys) {
         string[] keysArray = new string[keys.Length];
         keys.CopyTo(keysArray, 0);
         OneSignalNative.RemoveTriggersForKeys(keysArray);
      }

      public override object GetTrigger(string key) {
         return OneSignalNative.GetTriggerValueForKey(key);
      }

      public override Dictionary<string, object> GetTriggers() {
         return NativeConversion.NSDictToPureDict(OneSignalNative.GetTriggers());
      }

      public override bool InAppMessagesArePaused {
         get => OneSignalNative.IsInAppMessagingPaused();
         set => OneSignalNative.PauseInAppMessages(value);
      }

      public override async Task<bool> SendOutcome(string name) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SendOutcome(name, response => proxy.OnResponse(true));
         return await proxy;
      }

      public override async Task<bool> SendUniqueOutcome(string name) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SendUniqueOutcome(name, response => proxy.OnResponse(true));
         return await proxy;
      }

      public override async Task<bool> SendOutcomeWithValue(string name, float value) {
         BooleanCallbackProxy proxy = new BooleanCallbackProxy();
         OneSignalNative.SendOutcomeWithValue(name, value, response => proxy.OnResponse(true));
         return await proxy;
      }


   }
}
