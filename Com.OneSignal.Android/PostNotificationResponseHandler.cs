using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Org.Json;

namespace Com.OneSignal
{
    public class PostNotificationResponseHandler : Java.Lang.Object, Android.OneSignal.IPostNotificationResponseHandler
    {
        public void OnSuccess(JSONObject jsonObject)
        {
            Dictionary<string, object> dict = null;
            if (jsonObject != null)
                dict = Json.Deserialize(jsonObject.ToString()) as Dictionary<string, object>;
            (OneSignal.Current as OneSignalImplementation).onPostNotificationSuccess(dict);
        }

        public void OnFailure(JSONObject jsonObject)
        {
            Dictionary<string, object> dict = null;
            if (jsonObject != null)
                dict = Json.Deserialize(jsonObject.ToString()) as Dictionary<string, object>;
            (OneSignal.Current as OneSignalImplementation).onPostNotificationFailed(dict);
        }
    }
}
