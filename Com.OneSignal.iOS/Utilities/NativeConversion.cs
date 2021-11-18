using System.Collections.Generic;
using Foundation;
using Com.OneSignal.Core;

namespace Com.OneSignal {
    public static class NativeConversion {

        public static Dictionary<string, object> NSDictToPureDict(NSDictionary nsDict) {
            if (nsDict == null)
                return null;
            NSError error;
            NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
            NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
            string jsonString = jsonNSString.ToString();
            return Json.Deserialize(jsonString) as Dictionary<string, object>;
        }

        public static string NSDictToString(NSDictionary nsDict) {
            if (nsDict == null)
                return null;
            NSError error;
            NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
            NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
            return jsonNSString.ToString();
        }

        public static NSDictionary DictToNSDict(Dictionary<string, object> dict) {
            if (dict == null)
                return null;

            string jsonString = Json.Serialize(dict);
            NSString jsonNSString = new NSString(jsonString);
            NSData jsonData = jsonNSString.Encode(NSStringEncoding.UTF8);
            NSError error;
            NSDictionary nsDict = NSJsonSerialization.Deserialize(jsonData, 0, out error) as NSDictionary;

            return nsDict;
        }
    }
}
