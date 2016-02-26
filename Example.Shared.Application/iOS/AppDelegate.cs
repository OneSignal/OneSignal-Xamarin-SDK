using Foundation;
using UIKit;
using Com.OneSignal;
using System.Collections.Generic;

namespace Example.Shared.Application.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Notification Opened Delegate
			OneSignal.NotificationOpened exampleNotificationOpenedDelegate = delegate(string message, Dictionary<string, object> additionalData, bool isActive) {
				try
				{
					System.Console.WriteLine ("OneSignal Notification opened:\nMessage: {0}", message);

					if (additionalData != null)
					{
						if (additionalData.ContainsKey("customKey"))
							System.Console.WriteLine ("customKey: {0}", additionalData ["customKey"]);

						System.Console.WriteLine ("additionalData: {0}", additionalData);
					}
				}
				catch (System.Exception e)
				{
					System.Console.WriteLine (e.StackTrace);
				}
			};

			// Initialize OneSignal
			OneSignal.Init (exampleNotificationOpenedDelegate);

			return true;
		}
	}
}


