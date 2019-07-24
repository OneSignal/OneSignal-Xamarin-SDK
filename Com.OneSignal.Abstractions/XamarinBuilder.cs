using System;
using System.Collections.Generic;

namespace Com.OneSignal.Abstractions
{
   public class XamarinBuilder
   {
      public string mAppId;
      public Dictionary<string, bool> iOSSettings;
      public OSInFocusDisplayOption displayOption = OSInFocusDisplayOption.InAppAlert;
      public NotificationReceived _notificationReceivedDelegate;
      public NotificationOpened _notificationOpenedDelegate;
      public InAppMessageClicked _inAppMessageClickedDelegate;
      OneSignalShared mOneSignalShared;

      internal XamarinBuilder(string appId, OneSignalShared oneSignalShared)
      {
         mAppId = appId;
         mOneSignalShared = oneSignalShared;
      }

      // inNotificationReceivedDelegate   = Calls this delegate when a notification is received
      public XamarinBuilder HandleNotificationReceived(NotificationReceived inNotificationReceivedDelegate)
      {
         _notificationReceivedDelegate = inNotificationReceivedDelegate;
         return this;
      }

      // inNotificationOpenedDelegate     = Calls this delegate when a push notification is opened
      public XamarinBuilder HandleNotificationOpened(NotificationOpened inNotificationOpenedDelegate)
      {
         _notificationOpenedDelegate = inNotificationOpenedDelegate;
         return this;
      }

      // inAppMessageClickedDelegate      = Calls this delegate when an IAM element click occurs
       public XamarinBuilder HandleInAppMessageClicked(InAppMessageClicked inAppMessageClickedDelegate)
      {
         _inAppMessageClickedDelegate = inAppMessageClickedDelegate;
         return this;
      }

      public XamarinBuilder InFocusDisplaying(OSInFocusDisplayOption display)
      {
         displayOption = display;
         return this;
      }

      public XamarinBuilder UnsubscribeWhenNotificationsAreDisabled(bool set)
      {
         mOneSignalShared.UnsubscribeWhenNotificationsAreDisabled(set);
         return this;
      }

      // Pass one if the define kOSSettings strings as keys only. Only affects iOS platform.
      // autoPrompt                       = Set false to delay the iOS accept notification system prompt. Defaults true.
      //                                    You can then call RegisterForPushNotifications at a better point in your game to prompt them.
      // inAppLaunchURL                   = (iOS) Set false to force a ULRL to launch through Safari instead of in-app webview.

      public XamarinBuilder Settings(Dictionary<string, bool> settings)
      {
         iOSSettings = settings;
         return this;
      }

      public void EndInit()
      {
         mOneSignalShared.InitPlatform();
      }
   }
}
