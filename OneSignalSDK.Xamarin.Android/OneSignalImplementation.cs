using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Org.Json;

using OneSignalSDK.Xamarin.Core;

using Android.App;
using Android.Content;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.Xamarin {
   public partial class OneSignalImplementation : OneSignalSDKInternal {

      public LogLevel currentLogLevel;
      public LogLevel currentAlertLevel;

      public override event NotificationWillShowDelegate NotificationWillShow;
      public override event NotificationActionDelegate NotificationOpened;
      public override event InAppMessageLifecycleDelegate InAppMessageWillDisplay;
      public override event InAppMessageLifecycleDelegate InAppMessageDidDisplay;
      public override event InAppMessageLifecycleDelegate InAppMessageWillDismiss;
      public override event InAppMessageLifecycleDelegate InAppMessageDidDismiss;
      public override event InAppMessageActionDelegate InAppMessageTriggeredAction;
      public override event StateChangeDelegate<NotificationPermission> NotificationPermissionChanged;
      public override event StateChangeDelegate<PushSubscriptionState> PushSubscriptionStateChanged;
      public override event StateChangeDelegate<EmailSubscriptionState> EmailSubscriptionStateChanged;
      public override event StateChangeDelegate<SMSSubscriptionState> SMSSubscriptionStateChanged;

      public override bool PrivacyConsent {
         get => OneSignalNative.UserProvidedPrivacyConsent();
         set => OneSignalNative.ProvideUserConsent(value);
      }

      public override bool RequiresPrivacyConsent {
         get => OneSignalNative.RequiresUserPrivacyConsent();
         set => OneSignalNative.SetRequiresUserPrivacyConsent(value);
      }

      public override void Initialize(string appId) {
         Context context = Application.Context;
         OneSignalNative.SetAppId(appId);
         OneSignalNative.InitWithContext(context);

         OneSignalNative.AddPermissionObserver(new OSPermissionObserver());
         OneSignalNative.AddSubscriptionObserver(new OSPushSubscriptionObserver());
         OneSignalNative.AddEmailSubscriptionObserver(new OSEmailSubscriptionObserver());
         OneSignalNative.AddSMSSubscriptionObserver(new OSSMSSubscriptionObserver());

         OneSignalNative.SetNotificationWillShowInForegroundHandler(new OSNotificationWillShowInForegroundHandler());
         OneSignalNative.SetNotificationOpenedHandler(new OSNotificationOpenedHandler());
         OneSignalNative.SetInAppMessageClickHandler(new OSInAppMessageClickHandler());
         OneSignalNative.SetInAppMessageLifecycleHandler(new OSInAppMessageLifeCycleHandler());
      }

      public override async Task<NotificationPermission> PromptForPushNotificationsWithUserResponse() {
         return await PromptForPushNotificationsWithUserResponse(false);
      }

      public override async Task<NotificationPermission> PromptForPushNotificationsWithUserResponse(bool fallbackToSettings) {
         var handler = new OSPromptForPushNotificationPermissionResponseHandler();
         OneSignalNative.PromptForPushNotifications(fallbackToSettings, handler);
         return await handler ? NotificationPermission.Authorized : NotificationPermission.Denied;
      }


      public override LogLevel LogLevel {
         get => currentLogLevel;
         set {
            currentLogLevel = value;
            OneSignalNative.SetLogLevel(NativeConversion.LogConversion(currentLogLevel), NativeConversion.LogConversion(currentAlertLevel));
         }
      }

      public override LogLevel AlertLevel {
         get => currentAlertLevel;
         set {
            currentAlertLevel = value;
            OneSignalNative.SetLogLevel(NativeConversion.LogConversion(currentLogLevel), NativeConversion.LogConversion(currentAlertLevel));
         }
      }

      public override async Task<bool> SetSMSNumber(string smsNumber, string authHash = null) {
         OSSMSUpdateHandler handler = new OSSMSUpdateHandler();
         OneSignalNative.SetSMSNumber(smsNumber, authHash, handler);
         return await handler;
      }

      public override async Task<bool> SetEmail(string email, string authHash = null) {
         OSEmailUpdateHandler handler = new OSEmailUpdateHandler();
         OneSignalNative.SetEmail(email, authHash, handler);
         return await handler;
      }

      //Required as a quick fix for iOS setExternalUser non-nullable hashToken. Need removed as soon as OneSignal iOS updates hashToken to nullable
      public override async Task<bool> SetExternalUserId(string externalId) {
         OSExternalUserIDUpdateHandler handler = new OSExternalUserIDUpdateHandler();
         OneSignalNative.SetExternalUserId(externalId, handler);
         return await handler;
      }

      public override async Task<bool> SetExternalUserId(string externalId, string authHash = null) {
         OSExternalUserIDUpdateHandler handler = new OSExternalUserIDUpdateHandler();
         OneSignalNative.SetExternalUserId(externalId, authHash, handler);
         return await handler;
      }

      public override async Task<bool> RemoveExternalUserId() {
         OSExternalUserIDUpdateHandler handler = new OSExternalUserIDUpdateHandler();
         OneSignalNative.RemoveExternalUserId(handler);
         return await handler;
      }

      public override async Task<bool> LogoutEmail() {
         OSEmailUpdateHandler handler = new OSEmailUpdateHandler();
         OneSignalNative.LogoutEmail(handler);
         return await handler;
      }

      public override async Task<bool> LogoutSMS() {
         OSSMSUpdateHandler handler = new OSSMSUpdateHandler();
         OneSignalNative.LogoutSMSNumber(handler);
         return await handler;
      }

      public override DeviceState DeviceState => NativeConversion.DeviceStateToXam(OneSignalNative.DeviceState);

      public override NotificationPermission NotificationPermission {
         get {
            return DeviceState.notificationPermission;
         }
      }

      public override PushSubscriptionState PushSubscriptionState {
         get {
            return new PushSubscriptionState {
               userId = DeviceState.userId,
               pushToken = DeviceState.pushToken,
               isSubscribed = DeviceState.isSubscribed,
               isPushDisabled = DeviceState.isPushDisabled
            };
         }
      }

      public override EmailSubscriptionState EmailSubscriptionState {
         get {
            return new EmailSubscriptionState {
               emailUserId = DeviceState.emailUserId,
               emailAddress = DeviceState.emailAddress,
               isSubscribed = DeviceState.isEmailSubscribed
            };
         }
      }

      public override SMSSubscriptionState SMSSubscriptionState {
         get {
            return new SMSSubscriptionState {
               smsUserId = DeviceState.smsUserId,
               smsNumber = DeviceState.smsNumber,
               isSubscribed = DeviceState.isSMSSubscribed
            };
         }
      }

      public override void SetLaunchURLsInApp(bool launchInApp) {
         Console.WriteLine("OneSignal: SetLaunchURLsInApp is available on iOS only");
      }

      public override async Task<bool> SetLanguage(string language) {
         OSLanguageUpdateHandler handler = new OSLanguageUpdateHandler();
         OneSignalNative.SetLanguage(language, handler);
         return await handler;
      }

      public override async Task<bool> SendTag(string key, string value) {
         OneSignalNative.SendTag(key, value);
         return true;
      }

      public override async Task<bool> SendTags(Dictionary<string, object> tags) {
         OSChangeTagsUpdateHandler handler = new OSChangeTagsUpdateHandler();
         OneSignalNative.SendTags(new JSONObject(Json.Serialize(tags)), handler);
         return await handler;
      }

      public override async Task<Dictionary<string, object>> GetTags() {
         OSGetTagsHandler handler = new OSGetTagsHandler();
         OneSignalNative.GetTags(handler);
         return await handler;
      }

      public override async Task<bool> DeleteTag(string key) {
         OSChangeTagsUpdateHandler handler = new OSChangeTagsUpdateHandler();
         OneSignalNative.DeleteTag(key, handler);
         return await handler;
      }

      public override async Task<bool> DeleteTags(params string[] keys) {
         OSChangeTagsUpdateHandler handler = new OSChangeTagsUpdateHandler();
         OneSignalNative.DeleteTags(Json.Serialize(keys), handler);
         return await handler;
      }

      public override async Task<bool> PostNotification(Dictionary<string, object> options) {
         OSPostNotificationResponseHandler handler = new OSPostNotificationResponseHandler();
         OneSignalNative.PostNotification(Json.Serialize(options), handler);
         return await handler;
      }

      public override bool ShareLocation {
         get => OneSignalNative.LocationShared;
         set => OneSignalNative.LocationShared = value;
      }

      public override void PromptLocation() {
         OneSignalNative.PromptLocation();
      }

      public override void ClearOneSignalNotifications() {
         OneSignalNative.ClearOneSignalNotifications();
      }

      public override bool PushEnabled {
         get => !DeviceState.isPushDisabled;
         set => OneSignalNative.DisablePush(!value);
      }

      public override void SetTriggers(Dictionary<string, object> triggers) {
         IDictionary<string, Java.Lang.Object> jTriggers = new Dictionary<string, Java.Lang.Object>();
         foreach (var trigger in triggers) {
            jTriggers[trigger.Key] = NativeConversion.ToJavaObject(trigger.Value);
         }

         OneSignalNative.AddTriggers(jTriggers);
      }

      public override void SetTrigger(string key, object triggerObject) {
         OneSignalNative.AddTrigger(key, NativeConversion.ToJavaObject(triggerObject));
      }

      public override void RemoveTriggers(params string[] keys) {
         OneSignalNative.RemoveTriggersForKeys(keys);
      }

      public override void RemoveTrigger(string key) {
         OneSignalNative.RemoveTriggerForKey(key);
      }

      public override object GetTrigger(string key) {
         return OneSignalNative.GetTriggerValueForKey(key);
      }

      public override Dictionary<string, object> GetTriggers() {
         IDictionary<string, Java.Lang.Object> jTriggers = OneSignalNative.Triggers;
         Dictionary<string, object> triggers = new Dictionary<string, object>();

         foreach (var trigger in jTriggers) {
            triggers[trigger.Key] = trigger.Value;
         }

         return triggers;
      }

      public override bool InAppMessagesArePaused {
         get => OneSignalNative.IsInAppMessagingPaused;
         set => OneSignalNative.PauseInAppMessages(value);
      }

      public override async Task<bool> SendOutcome(string name) {
         OSOutcomeCallback handler = new OSOutcomeCallback();
         OneSignalNative.SendOutcome(name, handler);
         return await handler;
      }

      public override async Task<bool> SendUniqueOutcome(string name) {
         OSOutcomeCallback handler = new OSOutcomeCallback();
         OneSignalNative.SendUniqueOutcome(name, handler);
         return await handler;
      }

      public override async Task<bool> SendOutcomeWithValue(string name, float value) {
         OSOutcomeCallback handler = new OSOutcomeCallback();
         OneSignalNative.SendOutcomeWithValue(name, value, handler);
         return await handler;
      }

      public override Task<bool> EnterLiveActivity(string activityId, string token)
      {
         Console.WriteLine("OneSignal: EnterLiveActivity is available on iOS only");
         return Task.FromResult(false);
      }

      public override Task<bool> ExitLiveActivity(string activityId)
      {
         Console.WriteLine("OneSignal: ExitLiveActivity is available on iOS only");
         return Task.FromResult(false);
      }
   }
}
