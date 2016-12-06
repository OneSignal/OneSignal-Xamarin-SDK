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
         
         OneSignal.NotificationReceived exampleNotificationReceivedDelegate = delegate (OSNotification notification)
         {
            try
            {
               System.Console.WriteLine("OneSignal Notification Received:\nMessage: {0}", notification.payload.body);
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
         OneSignal.NotificationOpened exampleNotificationOpenedDelegate = delegate (OSNotificationOpenedResult result)
         {
            try
            {
               System.Console.WriteLine("OneSignal Notification opened:\nMessage: {0}", result.notification.payload.body);
               Dictionary<string, object> additionalData = result.notification.payload.additionalData;
               if (additionalData.Count > 0)
                  System.Console.WriteLine("additionalData: {0}", additionalData);
               
               
               List<Dictionary<string, object>> actionButtons = result.notification.payload.actionButtons;
               if (actionButtons.Count > 0)
                  System.Console.WriteLine("actionButtons: {0}", actionButtons);
            }
            catch (System.Exception e)
            {
               System.Console.WriteLine(e.StackTrace);
            }
         };
         
         // Initialize OneSignal
         OneSignal.StartInit("b2f7f966-d8cc-11e4-bed1-df8f05be55ba")
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


