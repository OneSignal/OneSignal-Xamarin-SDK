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
         OneSignal.Current.SetLogLevel(LOG_LEVEL.VERBOSE, LOG_LEVEL.WARN);

         //if you want to require user consent, change this to true
         SharedPush.SetRequiresConsent(false);

         OneSignal.Current.StartInit("b2f7f966-d8cc-11e4-bed1-df8f05be55ba").Settings(new Dictionary<string, bool>() {
            { IOSSettings.kOSSettingsKeyAutoPrompt, false },
            { IOSSettings.kOSSettingsKeyInAppLaunchURL, true } })
           .InFocusDisplaying(OSInFocusDisplayOption.Notification)
           .HandleNotificationOpened((result) =>
            {
               Debug.WriteLine("HandleNotificationOpened: {0}", result.notification.payload.body);
            })
           .HandleNotificationReceived((notification) =>
           {
              Debug.WriteLine("HandleNotificationReceived: {0}", notification.payload.body);
           })
           .EndInit();

         OneSignal.Current.IdsAvailable((playerID, pushToken) =>
         {
            Debug.WriteLine("OneSignal.Current.IdsAvailable:D playerID: {0}, pushToken: {1}", playerID, pushToken);
         });
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
   }
}
