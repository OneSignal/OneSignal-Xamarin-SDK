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

using System.Runtime.InteropServices;
using System.Collections.Generic;
using OneSignalPush.MiniJSON;

namespace Com.OneSignal
{
	public class OneSignalIOS : OneSignalPlatform
	{
		private Com.OneSignal.iOS.OneSignal mOneSignal;

		public static Dictionary<string, object> NSDictToPureDict(Foundation.NSDictionary nsDict)
		{
			Foundation.NSError error;
			Foundation.NSData jsonData = Foundation.NSJsonSerialization.Serialize (nsDict, (Foundation.NSJsonWritingOptions)0, out error);
			Foundation.NSString jsonNSString = Foundation.NSString.FromData (jsonData, Foundation.NSStringEncoding.UTF8);
			string jsonString = jsonNSString.ToString ();
			return Json.Deserialize (jsonString) as Dictionary<string, object>;
		}

		public OneSignalIOS (bool autoRegister, OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel)
		{
			this.SetLogLevel (logLevel, visualLevel);
			if (Com.OneSignal.OneSignal.notificationOpenedDelegate != null)
				mOneSignal = new Com.OneSignal.iOS.OneSignal (new Foundation.NSDictionary (), NotificationOpenedHandler, autoRegister);
			else
				mOneSignal = new Com.OneSignal.iOS.OneSignal (new Foundation.NSDictionary (), autoRegister);
		}
			
		public void RegisterForPushNotifications ()
		{
			this.mOneSignal.RegisterForPushNotifications ();
		}

		public void SendTag (string tagName, string tagValue)
		{
			this.mOneSignal.SendTag (tagName, tagValue);
		}

		public void SendTags (IDictionary<string, string> tags)
		{
			string jsonString = Json.Serialize (tags);
			this.mOneSignal.SendTagsWithJsonString (jsonString);
		}

		public void GetTags ()
		{
			this.mOneSignal.GetTags (GetTagsHandler);
		}

		public void DeleteTag (string key)
		{
			this.mOneSignal.DeleteTag (key);
		}

		public void DeleteTags (IList<string> keys)
		{
			Foundation.NSObject[] objs = new Foundation.NSObject[keys.Count];
			for (int i = 0; i < keys.Count; i++)
			{
				objs [i] = (Foundation.NSObject)(Foundation.NSString)keys [i];
			}
			this.mOneSignal.DeleteTags (objs);
		}

		public void IdsAvailable ()
		{
			this.mOneSignal.IdsAvailable (IdsAvailableHandler);
		}

		public void EnableInAppAlertNotification (bool enable)
		{
			this.mOneSignal.EnableInAppAlertNotification (enable);
		}

		public void SetSubscription (bool enable)
		{
			this.mOneSignal.SetSubscription (enable);
		}

		public void PostNotification (Dictionary<string, object> data)
		{
			string jsonString = Json.Serialize (data);
			this.mOneSignal.PostNotificationWithJsonString (jsonString, PostNotificationSuccessHandler, PostNotificationFailureHandler);
		}

		public void SetLogLevel (OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel)
		{
			Com.OneSignal.iOS.OneSLogLevel convertedLogLevel = (Com.OneSignal.iOS.OneSLogLevel)((ulong)((int)logLevel));
			Com.OneSignal.iOS.OneSLogLevel convertedVisualLevel = (Com.OneSignal.iOS.OneSLogLevel)((ulong)((int)visualLevel));
			Com.OneSignal.iOS.OneSignal.SetLogLevel (convertedLogLevel, convertedVisualLevel);
		}

		public void IdsAvailableHandler (string playerID, string pushToken)
		{
			Com.OneSignal.OneSignal.idsAvailableDelegate (playerID, pushToken);
		}

		public void NotificationOpenedHandler (string message, Foundation.NSDictionary additionalData, bool isActive)
		{
			Dictionary<string, object> dict = NSDictToPureDict (additionalData);
			Com.OneSignal.OneSignal.notificationOpenedDelegate (message, dict, isActive);
		}

		public void GetTagsHandler (Foundation.NSDictionary result)
		{
			Dictionary<string, object> dict = NSDictToPureDict (result);
			Com.OneSignal.OneSignal.tagsAvailableDelegate (dict);
		}

		public void PostNotificationSuccessHandler (Foundation.NSDictionary result)
		{
			Dictionary<string, object> dict = NSDictToPureDict (result);
			Com.OneSignal.OneSignal.onPostNotificationSuccessDelegate (dict);
		}

		public void PostNotificationFailureHandler (Foundation.NSError error)
		{
			if (error.UserInfo != null && error.UserInfo ["returned"] != null)
			{
				Dictionary<string, object> dict = NSDictToPureDict (error.UserInfo);
				Com.OneSignal.OneSignal.onPostNotificationFailureDelegate (dict);
			}
			else
				Com.OneSignal.OneSignal.onPostNotificationFailureDelegate (new Dictionary<string, object> { {"error", "HTTP no response error"} });
		}
	}
}