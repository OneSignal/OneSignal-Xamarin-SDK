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
using Org.Json;
using OneSignalPush.MiniJSON;
using Android.App;

namespace Com.OneSignal
{
	public class OneSignalAndroid : OneSignalPlatform
	{
		public OneSignalAndroid (OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel)
		{
			this.SetLogLevel (logLevel, visualLevel);
			if (Com.OneSignal.OneSignal.notificationOpenedDelegate != null)
				Com.OneSignal.Android.OneSignal.StartInit (Application.Context).SetNotificationOpenedHandler (new NotificationOpenedHandler()).Init ();
			else
				Com.OneSignal.Android.OneSignal.StartInit (Application.Context).Init ();
		}
			
		public void SendTag (string tagName, string tagValue)
		{
			Com.OneSignal.Android.OneSignal.SendTag (tagName, tagValue);
		}

		public void SendTags (IDictionary<string, string> tags)
		{
			Com.OneSignal.Android.OneSignal.SendTags (Json.Serialize (tags));
		}

		public void GetTags ()
		{
			Com.OneSignal.Android.OneSignal.GetTags (new GetTagsHandler ());
		}

		public void DeleteTag (string key)
		{
			Com.OneSignal.Android.OneSignal.DeleteTag (key);
		}

		public void DeleteTags (IList<string> keys)
		{
			Com.OneSignal.Android.OneSignal.DeleteTags (Json.Serialize (keys));
		}

		public void IdsAvailable ()
		{
			Com.OneSignal.Android.OneSignal.IdsAvailable (new IdsAvailableHandler ());
		}

		public void RegisterForPushNotifications () { } // Doesn't apply to Android as the Native SDK always registers with GCM.

		public void EnableVibrate (bool enable)
		{
			Com.OneSignal.Android.OneSignal.EnableVibrate (enable);
		}

		public void EnableSound (bool enable)
		{
			Com.OneSignal.Android.OneSignal.EnableSound (enable);
		}

		public void EnableInAppAlertNotification (bool enable)
		{
			Com.OneSignal.Android.OneSignal.EnableInAppAlertNotification (enable);
		}

		public void EnableNotificationsWhenActive (bool enable)
		{
			Com.OneSignal.Android.OneSignal.EnableNotificationsWhenActive (enable);
		}

		public void SetSubscription (bool enable)
		{
			Com.OneSignal.Android.OneSignal.SetSubscription (enable);
		}

		public void PostNotification (Dictionary<string, object> data)
		{
			Com.OneSignal.Android.OneSignal.PostNotification (Json.Serialize (data), new PostNotificationResponseHandler ());
		}

		public void SetLogLevel (OneSignal.LOG_LEVEL logLevel, OneSignal.LOG_LEVEL visualLevel)
		{
			Com.OneSignal.Android.OneSignal.SetLogLevel ((int)logLevel, (int)visualLevel);
		}
			
		private class IdsAvailableHandler : Java.Lang.Object, Com.OneSignal.Android.OneSignal.IIdsAvailableHandler
		{
			public void IdsAvailable (string p0, string p1)
			{
				OneSignal.idsAvailableDelegate (p0, p1);
			}
		}

		private class NotificationOpenedHandler : Java.Lang.Object, Com.OneSignal.Android.OneSignal.INotificationOpenedHandler
		{
			public void NotificationOpened (string message, JSONObject additionalData, bool isActive)
			{
				Dictionary<string, object> dict = null;
				if (additionalData != null)
					dict = Json.Deserialize (additionalData.ToString ()) as Dictionary<string, object>;
				OneSignal.notificationOpenedDelegate (message, dict, isActive);
			}
		}

		private class GetTagsHandler : Java.Lang.Object, Com.OneSignal.Android.OneSignal.IGetTagsHandler
		{
			public void TagsAvailable (JSONObject jsonObject)
			{
				Dictionary<string, object> dict = null;
				if (jsonObject != null)
					dict = Json.Deserialize (jsonObject.ToString ()) as Dictionary<string, object>;
				OneSignal.tagsAvailableDelegate (dict);
			}
		}

		private class PostNotificationResponseHandler : Java.Lang.Object, Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler
		{
			public void OnSuccess (JSONObject jsonObject)
			{
				Dictionary<string, object> dict = null;
				if (jsonObject != null)
					dict = Json.Deserialize (jsonObject.ToString ()) as Dictionary<string, object>;
				OneSignal.onPostNotificationSuccessDelegate (dict);
			}

			public void OnFailure (JSONObject jsonObject)
			{
				Dictionary<string, object> dict = null;
				if (jsonObject != null)
					dict = Json.Deserialize (jsonObject.ToString ()) as Dictionary<string, object>;
				OneSignal.onPostNotificationFailureDelegate (dict);
			}
		}
	}
}