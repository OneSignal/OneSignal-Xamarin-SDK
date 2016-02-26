/*
ProtoIntegrationTest.cs
- Add the RunTests function to MainActivity/AppDelegate class to test Android/iOS.
- Make sure you edit userId, which is the player ID to send the notification to.
- Call the function from a separate thread after calling OneSignal.Init ():
// Run Tests
System.Threading.Thread th = new System.Threading.Thread (RunTests);
th.Start ();
*/

public static void RunTests ()
{
	// SETUP DELEGATES
	// tag printer delegate for get tags
	OneSignal.TagsAvailable tagPrinterDelegate = delegate(System.Collections.Generic.Dictionary<string, object> tags) {
		if (tags == null)
		{
			System.Console.WriteLine ("No tags found!");
			return;
		}
		foreach (KeyValuePair<string, object> kvp in tags)
		{
			System.Console.WriteLine ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
		}
	};
	// id printer delegate for get ids available
	OneSignal.IdsAvailable idsPrinterDelegate = delegate(string playerID, string pushToken) {
		System.Console.WriteLine ("playerId: {0}, pushToken: {1}", playerID, pushToken);
	};
	// post notification delegates
	OneSignal.OnPostNotificationSuccess successDelegate = delegate(Dictionary<string, object> response) {
		if (response == null)
		{
			System.Console.WriteLine ("No response found!");
			return;
		}
		System.Console.WriteLine ("SUCCESS: {0}", response);
	};
	OneSignal.OnPostNotificationFailure failureDelegate = delegate(Dictionary<string, object> response) {
		if (response == null)
		{
			System.Console.WriteLine ("No response found!");
			return;
		}
		System.Console.WriteLine ("FAILURE: {0}", response);
	};

	// Disabling in-app alerts
	OneSignal.EnableInAppAlertNotification (false);

	// Delete all tags before test starts (implicitly testing delete tags)
	System.Console.Write ("Deleting hello, foo, fuz...");
	OneSignal.DeleteTags (new List<string>() { "hello", "foo", "fuz" });
	System.Console.WriteLine ("DONE!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Tags Testing: Open Xcode Devices and follow the steps
	// Test #1: Send the first tag to OneSignal
	System.Console.Write ("Sending {hello, world} tag...");
	OneSignal.SendTag ("hello", "world");
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Now go and check the dashboard. Quick!!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #2: Send the other tags to OneSignal
	System.Console.Write ("Sending {foo, bar; fuz, baz} tag...");
	OneSignal.SendTags (new Dictionary<string, string>() { {"foo", "bar"}, {"fuz", "baz"} } );
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Now go and check the dashboard. Quick!!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #3: Get all tags from OneSignal
	System.Console.Write ("Getting all tags...");
	OneSignal.GetTags (tagPrinterDelegate);
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Now check to make sure all tags were returned here. Quick!!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #4: Delete last tag sent
	System.Console.Write ("Deleting the fuz tag...");
	OneSignal.DeleteTag ("fuz");
	System.Console.Write ("DONE!");
	System.Console.WriteLine ("Now go and check the dashboard. Quick!!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #5: Get Ids Available
	System.Console.Write ("Getting player ID and push token...");
	OneSignal.GetIdsAvailable (idsPrinterDelegate);
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Now check to make sure correct push token and player id were returned here. Quick!!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #6: Post Notification
	string userId = "EDITME";

	// Success
	Dictionary<string, object> goodNotification = new Dictionary<string, object>();
	goodNotification["contents"] = new Dictionary<string, string>() { {"en", "Test Message"} };
	goodNotification["include_player_ids"] = new List<string>() { userId };
	System.Console.Write ("Sending a good notification to self...");
	OneSignal.PostNotification (goodNotification, successDelegate, failureDelegate);
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Check the log quick!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Failure
	Dictionary<string, object> badNotification = new Dictionary<string, object>();
	badNotification["contentz"] = new Dictionary<string, string>() { {"en", "Test Message"} };
	badNotification["include_player_ids"] = new List<string>() { userId };
	System.Console.Write ("Sending a bad notification to self...");
	OneSignal.PostNotification (badNotification, successDelegate, failureDelegate);
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Check the log quick!");
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");

	// Test #7: Disable Stuff (Android Only)
	System.Console.Write ("Disabling Sound, Vibrate, and Notification when active...");
	OneSignal.EnableSound (false);
	OneSignal.EnableVibrate (false);
	OneSignal.EnableNotificationsWhenActive (false);
	System.Console.WriteLine ("DONE!");
	System.Console.WriteLine ("Now send a notification and check the sound, vibration, enable notification when active and in-app alert. Quick!!");
	System.Console.Write ("Sleeping for 30 seconds...");
	System.Threading.Thread.Sleep (30000);
	System.Console.WriteLine ("DONE!");

	// Test #8: Enable In-App Alert
	System.Console.Write ("Enabling In-App Alert...");
	OneSignal.EnableInAppAlertNotification (true);
	System.Console.WriteLine ("DONE!");	
	OneSignal.PostNotification (goodNotification, successDelegate, failureDelegate);
	System.Console.Write ("Sleeping for 15 seconds...");
	System.Threading.Thread.Sleep (15000);
	System.Console.WriteLine ("DONE!");
}