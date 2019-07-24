using System;
using System.Collections.Generic;
using System.Diagnostics;

using Com.OneSignal;
using Com.OneSignal.Abstractions;

namespace Com.OneSignal.Sample.Shared
{
   public static class SharedPush
   {
      // Called on iOS and Android to initialize OneSignal
      public static void Initialize()
      {
         OneSignal.Current.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.NONE);

         //if you want to require user consent, change this to true
         SharedPush.SetRequiresConsent(false);

         OneSignal.Current.StartInit("b2f7f966-d8cc-11e4-bed1-df8f05be55ba").Settings(new Dictionary<string, bool>() {
            { IOSSettings.kOSSettingsKeyAutoPrompt, false },
            { IOSSettings.kOSSettingsKeyInAppLaunchURL, true } })
           .InFocusDisplaying(OSInFocusDisplayOption.Notification)
           .UnsubscribeWhenNotificationsAreDisabled(true)
           .HandleNotificationOpened((result) =>
            {
               Debug.WriteLine("HandleNotificationOpened: {0}", result.notification.payload.body);
            })
           .HandleNotificationReceived((notification) =>
           {
              Debug.WriteLine("HandleNotificationReceived: {0}", notification.payload.body);
           })
           .HandleInAppMessageClicked((action) =>
           {
              // Example IAM click handling for IAM elements
              Debug.WriteLine("HandledInAppMessageClicked: {0}", action.clickName);
           })
           .EndInit();

         OneSignal.Current.IdsAvailable((playerID, pushToken) =>
         {
            Debug.WriteLine("OneSignal.Current.IdsAvailable:D playerID: {0}, pushToken: {1}", playerID, pushToken);
         });

         OneSignalInAppMessagingDemo();
      }

      private static void OneSignalInAppMessagingDemo()
      {
         // Add a trigger to show an IAM
         OneSignal.Current.AddTrigger("trigger_1", "one");

         // Get the trigger value for a trigger key
         object value = OneSignal.Current.GetTriggerValueForKey("trigger_1");
         Debug.WriteLine("trigger_1 value: " + value);

         // Add multiple triggers at once
         Dictionary<string, object> triggers = new Dictionary<string, object>();
         triggers.Add("trigger_2", "two");
         triggers.Add("trigger_3", "three");
         OneSignal.Current.AddTriggers(triggers);

         // Remove a trigger
         OneSignal.Current.RemoveTriggerForKey("trigger_2");

         // Remove several triggers at once
         List<string> removeKeys = new List<string>();
         removeKeys.Add("trigger_1");
         removeKeys.Add("trigger_3");
         OneSignal.Current.RemoveTriggersForKeys(removeKeys);

         // Toggle showing of IAMs
         OneSignal.Current.PauseInAppMessages(false);
      }

      // Just for iOS.
      // No effect on Android, device auto registers without prompting.
      public static void RegisterIOS()
      {
         OneSignal.Current.RegisterForPushNotifications();
      }
      
      public static void ConsentStatusChanged(bool consent) {
         OneSignal.Current.UserDidProvidePrivacyConsent(consent);
      }
      
      public static bool UserDidProvideConsent() {
         return !OneSignal.Current.RequiresUserPrivacyConsent();
      }
      
      public static void SetRequiresConsent(bool required) {
         OneSignal.Current.SetRequiresUserPrivacyConsent(required);
      }
      
      public static void SetExternalUserId(string externalId) {
         OneSignal.Current.SetExternalUserId(externalId);
      }
      
      public static void RemoveExternalUserId() {
         OneSignal.Current.RemoveExternalUserId();
      }
   }
}
