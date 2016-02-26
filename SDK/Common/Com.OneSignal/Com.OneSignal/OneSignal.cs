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

#if __IOS__ || __ANDROID__
#define ONESIGNAL_PLATFORM
#define SUPPORTS_LOGGING
#endif

using System.Collections;
using System.Collections.Generic;
using OneSignalPush.MiniJSON;

namespace Com.OneSignal
{
	public class OneSignal
	{
		// platform detection variables
		//private static bool isAndroidPlatform;
		//private static bool isIOSPlatform;
		//private static bool isOneSignalPlatform;
		//private static bool supportsLogging;

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
			//isAndroidPlatform = (CrossDeviceInfo.Current.Platform == Platform.Android);
			//isIOSPlatform = (CrossDeviceInfo.Current.Platform == Platform.iOS);
			//isOneSignalPlatform = (isAndroidPlatform || isIOSPlatform);
			//supportsLogging = (isAndroidPlatform || isIOSPlatform);

			#if ONESIGNAL_PLATFORM
				OneSignal.notificationOpenedDelegate = notificationOpenedDelegate;

				if (initialized)
					return;
				#if __ANDROID__
					oneSignalPlatform = new OneSignalAndroid (logLevel, visualLevel);
				#elif __IOS__
					oneSignalPlatform = new OneSignalIOS (autoRegister, logLevel, visualLevel);
				#endif
					
				initialized = true;
			#endif
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
			#if SUPPORTS_LOGGING
				OneSignal.logLevel = logLevel;
				OneSignal.visualLevel = visualLevel;
			#endif
		}

		// Tag player with a key value pair to later create segments on them at onesignal.com.
		public static void SendTag (string tagName, string tagValue)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.SendTag (tagName, tagValue);
			#endif
		}

		// Tag player with a key value pairs to later create segments on them at onesignal.com.
		public static void SendTags (IDictionary<string, string> tags)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.SendTags (tags);
			#endif
		}

		// Makes a request to onesignal.com to get current tags set on the player and then run the callback passed in.
		public static void GetTags (TagsAvailable tagsAvailableDelegate)
		{
			#if ONESIGNAL_PLATFORM
				OneSignal.tagsAvailableDelegate = tagsAvailableDelegate;
				oneSignalPlatform.GetTags ();
			#endif
		}
			
		public static void GetTags ()
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.GetTags ();
			#endif
		}

		public static void DeleteTag (string key)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.DeleteTag (key);
			#endif
		}

		public static void DeleteTags (IList<string> keys)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.DeleteTags (keys);
			#endif
		}
			
		public static void RegisterForPushNotifications ()
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.RegisterForPushNotifications ();
			#endif
		}
			
		public static void GetIdsAvailable (IdsAvailable idsAvailableDelegate)
		{
			#if ONESIGNAL_PLATFORM
				OneSignal.idsAvailableDelegate = idsAvailableDelegate;
				oneSignalPlatform.IdsAvailable ();
			#endif
		}
			
		public static void GetIdsAvailable ()
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.IdsAvailable ();
			#endif
		}

		public static void EnableVibrate (bool enable)
		{
			#if __ANDROID__
				((OneSignalAndroid)oneSignalPlatform).EnableVibrate (enable);
			#endif
		}

		public static void EnableSound (bool enable)
		{
			#if __ANDROID__
				((OneSignalAndroid)oneSignalPlatform).EnableSound (enable);
			#endif
		}

		public static void EnableNotificationsWhenActive (bool enable)
		{
			#if __ANDROID__
				((OneSignalAndroid)oneSignalPlatform).EnableNotificationsWhenActive (enable);
			#endif
		}

		public static void EnableInAppAlertNotification (bool enable)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.EnableInAppAlertNotification (enable);
			#endif
		}

		public static void SetSubscription (bool enable)
		{
			#if ONESIGNAL_PLATFORM
				oneSignalPlatform.SetSubscription (enable);
			#endif
		}

		public static void PostNotification (Dictionary<string, object> data)
		{
			#if ONESIGNAL_PLATFORM
				PostNotification (data, null, null);
			#endif
		}

		public static void PostNotification (Dictionary<string, object> data, OnPostNotificationSuccess onPostNotificationSuccessDelegate, OnPostNotificationFailure onPostNotificationFailureDelegate)
		{
			#if ONESIGNAL_PLATFORM
				OneSignal.onPostNotificationSuccessDelegate = onPostNotificationSuccessDelegate;
				OneSignal.onPostNotificationFailureDelegate = onPostNotificationFailureDelegate;
				oneSignalPlatform.PostNotification (data);
			#endif
		}
	}
}