/**
 * Modified MIT License
 * 
 * Copyright 2016 OneSignal
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * 1. The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * 2. All copies of substantial portions of the Software may only be used in connection
 * with services provided by OneSignal.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System.Collections;
using System.Collections.Generic;
using OneSignalPush.MiniJSON;
using Xamarin.Forms;

namespace Com.OneSignal
{
	public class OneSignal
	{
		// platform detection variables
		private static bool isAndroidPlatform;
		private static bool isIOSPlatform;
		private static bool isOneSignalPlatform;
		private static bool supportsLogging;

		// delegate types
		public delegate void IdsAvailable(string playerID, string pushToken);
		public delegate void NotificationOpened(string message, Dictionary<string, object> additionalData, bool isActive);
		public delegate void TagsAvailable(Dictionary<string, object> tags);
		public delegate void OnPostNotificationSuccess(Dictionary<string, object> response);
		public delegate void OnPostNotificationFailure(Dictionary<string, object> response);

		// delegates
		public static IdsAvailable idsAvailableDelegate = null;
		public static NotificationOpened notificationOpenedDelegate = null;
		public static TagsAvailable tagsAvailableDelegate = null;
		internal static OnPostNotificationSuccess onPostNotificationSuccessDelegate = null;
		internal static OnPostNotificationFailure onPostNotificationFailureDelegate = null;

		// logging
		public enum LOG_LEVEL
		{
			NONE, FATAL, ERROR, WARN, INFO, DEBUG, VERBOSE
		}
		private static LOG_LEVEL logLevel = LOG_LEVEL.INFO, visualLevel = LOG_LEVEL.NONE;

		// shared platform member
		private static OneSignalPlatform oneSignalPlatform = null;

		// for initialization protection
		private static bool initialized = false;

		// Init - Only required method you call to setup OneSignal to receive push notifications.
		public static void Init (NotificationOpened notificationOpenedDelegate, bool autoRegister)
		{
			isAndroidPlatform = (Device.OS == TargetPlatform.Android);
			isIOSPlatform = (Device.OS == TargetPlatform.iOS);
			isOneSignalPlatform = (isAndroidPlatform || isIOSPlatform);
			supportsLogging = (isAndroidPlatform || isIOSPlatform);

			if (isOneSignalPlatform)
			{
				OneSignal.notificationOpenedDelegate = notificationOpenedDelegate;

				if (initialized)
					return;
				if (isAndroidPlatform)
				{
					oneSignalPlatform = new OneSignalAndroid (logLevel, visualLevel);

				}
				else if (isIOSPlatform)
				{
					oneSignalPlatform = new OneSignalIOS (autoRegister, logLevel, visualLevel);
				}
					
				initialized = true;
			}
		}

		// Auxiliary Constructors
		public static void Init (NotificationOpened notificationOpenedDelegate)
		{
			Init(notificationOpenedDelegate, true);
		}
		public static void Init ()
		{
			Init(null, true);
		}

		public static void SetLogLevel (LOG_LEVEL logLevel, LOG_LEVEL visualLevel)
		{
			if (supportsLogging)
			{
				OneSignal.logLevel = logLevel;
				OneSignal.visualLevel = visualLevel;
			}
		}

		// Tag player with a key value pair to later create segments on them at onesignal.com.
		public static void SendTag (string tagName, string tagValue)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.SendTag (tagName, tagValue);
			}
		}

		// Tag player with a key value pairs to later create segments on them at onesignal.com.
		public static void SendTags (IDictionary<string, string> tags)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.SendTags (tags);
			}
		}

		// Makes a request to onesignal.com to get current tags set on the player and then run the callback passed in.
		public static void GetTags (TagsAvailable tagsAvailableDelegate)
		{
			if (isOneSignalPlatform)
			{
				OneSignal.tagsAvailableDelegate = tagsAvailableDelegate;
				oneSignalPlatform.GetTags ();
			}
		}
			
		public static void GetTags ()
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.GetTags ();
			}
		}

		public static void DeleteTag (string key)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.DeleteTag (key);
			}
		}

		public static void DeleteTags (IList<string> keys)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.DeleteTags (keys);
			}
		}
			
		public static void RegisterForPushNotifications ()
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.RegisterForPushNotifications ();
			}
		}
			
		public static void GetIdsAvailable (IdsAvailable idsAvailableDelegate)
		{
			if (isOneSignalPlatform)
			{
				OneSignal.idsAvailableDelegate = idsAvailableDelegate;
				oneSignalPlatform.IdsAvailable ();
			}
		}
			
		public static void GetIdsAvailable ()
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.IdsAvailable ();
			}
		}

		public static void EnableVibrate (bool enable)
		{
			if (isAndroidPlatform)
			{
				((OneSignalAndroid)oneSignalPlatform).EnableVibrate (enable);
			}
		}

		public static void EnableSound (bool enable)
		{
			if (isAndroidPlatform)
			{
				((OneSignalAndroid)oneSignalPlatform).EnableSound (enable);
			}
		}

		public static void EnableNotificationsWhenActive (bool enable)
		{
			if (isAndroidPlatform)
			{
				((OneSignalAndroid)oneSignalPlatform).EnableNotificationsWhenActive (enable);
			}
		}

		public static void EnableInAppAlertNotification (bool enable)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.EnableInAppAlertNotification (enable);
			}
		}

		public static void SetSubscription (bool enable)
		{
			if (isOneSignalPlatform)
			{
				oneSignalPlatform.SetSubscription (enable);
			}
		}

		public static void PostNotification (Dictionary<string, object> data)
		{
			if (isOneSignalPlatform)
			{
				PostNotification (data, null, null);
			}
		}

		public static void PostNotification (Dictionary<string, object> data, OnPostNotificationSuccess onPostNotificationSuccessDelegate, OnPostNotificationFailure onPostNotificationFailureDelegate)
		{
			if (isOneSignalPlatform)
			{
				OneSignal.onPostNotificationSuccessDelegate = onPostNotificationSuccessDelegate;
				OneSignal.onPostNotificationFailureDelegate = onPostNotificationFailureDelegate;
				oneSignalPlatform.PostNotification (data);
			}
		}
	}
}