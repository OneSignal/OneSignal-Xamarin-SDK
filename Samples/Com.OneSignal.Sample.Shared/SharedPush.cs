using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using Com.OneSignal;
using Com.OneSignal.Core;

namespace Com.OneSignal.Sample.Shared
{
   public static class SharedPush
   {
      // Called on iOS and Android to initialize OneSignal
      public static void Initialize()
      {
         //OneSignal.Default.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

         OneSignal.Default.LogLevel = LogType.VERBOSE;
         OneSignal.Default.AlertLevel = LogType.NONE;

         //if you want to require user consent, change this to true
         //SharedPush.SetRequiresConsent(false);

         OneSignal.Default.RequiresPrivacyConsent = true;
         OneSignal.Default.PrivacyConsent = true;

         OneSignal.Default.Initialize("77e32082-ea27-42e3-a898-c72e141824ef");
         //OneSignal.Default.StartInit("b2f7f966-d8cc-11e4-bed1-df8f05be55ba").Settings(new Dictionary<string, bool>() {
         //   { IOSSettings.kOSSettingsKeyAutoPrompt, false },
         //   { IOSSettings.kOSSettingsKeyInAppLaunchURL, true } })
         //  .InFocusDisplaying(OSInFocusDisplayOption.Notification)
         //  .UnsubscribeWhenNotificationsAreDisabled(true)
         //  .HandleNotificationOpened((result) =>
         //   {
         //      Debug.WriteLine("HandleNotificationOpened: {0}", result.notification.payload.body);
         //   })
         //  .HandleNotificationReceived((notification) =>
         //  {
         //     Debug.WriteLine("HandleNotificationReceived: {0}", notification.payload.body);
         //  })
         //  .HandleInAppMessageClicked((action) =>
         //  {
         //     // Example IAM click handling for IAM elements
         //     Debug.WriteLine("HandledInAppMessageClicked: {0}", action.clickName);
         //  })
         //  .EndInit();

         //OneSignal.Default.IdsAvailable((playerID, pushToken) => {
         //   Debug.WriteLine("OneSignal.Default.IdsAvailable:D playerID: {0}, pushToken: {1}", playerID, pushToken);
         //});

         OneSignalInAppMessagingDemo();
         OneSignalOutcomeEventDemo();
      }

      private static void OneSignalSetExternalUSerId(Dictionary<string , object> results)
      {
         Debug.WriteLine("External user id updated with results: " + Json.Serialize(results));
      }

      private static void OneSignalInAppMessagingDemo()
      {
         // Add a trigger to show an IAM
         OneSignal.Default.SetTrigger("trigger_1", "one");

         // Get the trigger value for a trigger key
         object value = OneSignal.Default.GetTrigger("trigger_1");
         Debug.WriteLine("trigger_1 value: " + value);

         // Add multiple triggers at once
         Dictionary<string, object> triggers = new Dictionary<string, object>();
         triggers.Add("trigger_2", "two");
         triggers.Add("trigger_3", "three");
         OneSignal.Default.SetTriggers(triggers);

         // Remove a trigger
         OneSignal.Default.RemoveTrigger("trigger_2");

         // Remove several triggers at once
         List<string> removeKeys = new List<string>();
         removeKeys.Add("trigger_1");
         removeKeys.Add("trigger_3");
         OneSignal.Default.RemoveTriggers(removeKeys);

         // Toggle showing of IAMs
         OneSignal.Default.InAppMessagesArePaused = false;
      }

      private static void OneSignalOutcomeEventDemo()
      {
         // Show a normal outcome with and without a callback
         OneSignal.Default.SendOutcome("normal_1");

         //result.
         // Show a unique outcome with and without a callback
         OneSignal.Default.SendUniqueOutcome("unique_1");


         // Show an outcome with value with and without a callback
         OneSignal.Default.SendOutcomeWithValue("value_1", 3.2f);
      }

      // Just for iOS.
      // No effect on Android, device auto registers without prompting.
      public static void RegisterIOS() {
         OneSignal.Default.RegisterForPushNotification();
      }

      public static void ConsentStatusChanged(bool consent) {
         OneSignal.Default.PrivacyConsent = consent;
      }

      public static bool UserDidProvideConsent() {
         return !OneSignal.Default.RequiresPrivacyConsent;
      }

      public static void SetRequiresConsent(bool required) {
         OneSignal.Default.RequiresPrivacyConsent = required;
      }

      public static void SetExternalUserId(string externalId) {
         //OneSignal.Default.SetExternalUserId(externalId, OneSignalSetExternalUSerId);
         OneSignal.Default.SetExternalUserId(externalId);

         // Auth external id method
         //OneSignal.Default.SetExternalUserId(externalId, "your_auth_hash_token", OneSignalSetExternalUSerId, OneSignalSetExternalUSerId);
         OneSignal.Default.SetExternalUserId(externalId, "your_auth_hash_token");
      }

      public static void RemoveExternalUserId() {
         OneSignal.Default.Logout(LogoutOptions.ExternalUserId);
      }

      public static void SendOutcome(string outcomeName) {
         OneSignal.Default.SendOutcome(outcomeName);
      }

      public static void SendUniqueOutcome(string outcomeName) {
         OneSignal.Default.SendUniqueOutcome(outcomeName);
      }

      public static void SendOutcomeWithValue(string outcomeName, float value) {
         OneSignal.Default.SendOutcomeWithValue(outcomeName, value);
      }
   }
}
