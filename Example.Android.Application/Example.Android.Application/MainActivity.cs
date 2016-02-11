using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using System;
using Org.Json;
using Com.Onesignal;

namespace Example.Android.Application
{
	[Activity (Label = "Example.Android.Application", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Initialize OneSignal
			OneSignal.StartInit (this).SetNotificationOpenedHandler (new ExampleNotificationOpenedHandler ()).Init ();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		private class ExampleNotificationOpenedHandler : Java.Lang.Object, OneSignal.INotificationOpenedHandler
		{
			public void NotificationOpened (string message, JSONObject additionalData, bool isActive)
			{
				try
				{
					if (additionalData != null)
					{
						if (additionalData.Has ("actionSelected"))
						{
							Log.Debug ("OneSignalExample", "OneSignal notification button with id " + additionalData.GetString ("actionSelected") + " pressed");

							Log.Debug ("OneSignalExample", "Full additionalData:\n" + additionalData.ToString ());
						}
					}
				}
				catch (Exception e) {
					Console.WriteLine (e.StackTrace);
				}
			}
		}
	}
}