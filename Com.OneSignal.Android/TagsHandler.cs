using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Org.Json;

namespace Com.OneSignal
{
    public class TagsHandler : Java.Lang.Object, Android.OneSignal.IGetTagsHandler
    {
        public void TagsAvailable(JSONObject jsonObject)
        {
            Dictionary<string, object> dict = null;
            if (jsonObject != null)
                dict = Json.Deserialize(jsonObject.ToString()) as Dictionary<string, object>;
            (OneSignal.Current as OneSignalImplementation).onTagsReceived(dict);
        }
    }
}
