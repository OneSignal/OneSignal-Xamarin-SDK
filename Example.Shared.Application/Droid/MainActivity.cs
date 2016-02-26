using Android.App;
using Android.Widget;
using Android.OS;
using Com.OneSignal;
using System.Collections.Generic;

namespace Example.Shared.Application.Droid
{
	[Activity (Label = "Example.Shared.Application", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

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

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}
	}
}


