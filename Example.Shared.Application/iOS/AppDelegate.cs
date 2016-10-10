using Foundation;
using UIKit;
using Com.OneSignal;
using System.Collections.Generic;

namespace Example.Shared.Application.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate {
		// class-level declarations

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions) {

         OneSignal.NotificationReceived exampleNotificationReceivedDelegate = delegate (OSNotification notification)
         {
            try
            {
               System.Console.WriteLine("OneSignal Notification Received: {0}", notification.payload.body);
               Dictionary<string, object> additionalData = notification.payload.additionalData;

               if (additionalData.Count > 0)
                  System.Console.WriteLine("additionalData: {0}", additionalData);
            }
            catch (System.Exception e)
            {
               System.Console.WriteLine(e.StackTrace);
            }
         };
         
			// Notification Opened Delegate
			OneSignal.NotificationOpened exampleNotificationOpenedDelegate = delegate(OSNotificationOpenedResult result)
         {
				try
				{
               System.Console.WriteLine ("OneSignal Notification opened: {0}", result.notification.payload.body);
               
               Dictionary<string, object> additionalData = result.notification.payload.additionalData;
               List<Dictionary<string, object>> actionButtons = result.notification.payload.actionButtons;
               
               if (additionalData.Count > 0)
                  System.Console.WriteLine("additionalData: {0}", additionalData);

               if (actionButtons.Count > 0)
                  System.Console.WriteLine ("actionButtons: {0}", actionButtons);
				}
				catch (System.Exception e)
				{
					System.Console.WriteLine (e.StackTrace);
				}
			};
         
         // Initialize OneSignal
         OneSignal.StartInit("5eb5a37e-b458-11e3-ac11-000c2940e62c")
                  .HandleNotificationReceived(exampleNotificationReceivedDelegate)
                  .HandleNotificationOpened(exampleNotificationOpenedDelegate)
                  .InFocusDisplaying(OneSignal.OSInFocusDisplayOption.Notification)
                  .Settings(new Dictionary<string, bool> { { OneSignal.kOSSettingsKeyAutoPrompt, true }, { OneSignal.kOSSettingsKeyInAppLaunchURL, false } })
                  .EndInit();
         
         OneSignal.IdsAvailable((playerID, pushToken) =>
            {
               try
               {
                  System.Console.WriteLine("Player ID: " + playerID);
                  if (pushToken != null)
                     System.Console.WriteLine("Push Token: " + pushToken);
               }
               catch (System.Exception e)
               {
                  System.Console.WriteLine(e.StackTrace);
               }
            });
         
			return true;
		}
	}
}


