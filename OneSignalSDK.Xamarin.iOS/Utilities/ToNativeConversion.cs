using System.Collections.Generic;
using Foundation;
using HomeKit;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Internal.Utilities;

namespace OneSignalSDK.Xamarin.iOS.Utilities;

/// <summary>
/// Translation functions when translating from .NET SDK class types to their respective native SDK class types.
/// </summary>
public static class NativeConversion
{
    public static NSDictionary<NSString, NSObject> DictToNSDict(IDictionary<string, object> dict)
    {
        if (dict == null)
            return null;

        var keys = new NSString[dict.Count];
        var values = new NSObject[dict.Count];
        var index = 0;
        foreach(var entry in dict)
        {
            keys[index] = NSString.FromData(entry.Key, NSStringEncoding.UTF8);
            values[index] = NSObject.FromObject(entry.Value);
            index++;
        }

        var result = new NSDictionary<NSString, NSObject>(keys, values);

        return result;
    }

    public static NSDictionary<NSString, NSString> DictToNSDict(IDictionary<string, string> dict)
    {
        if (dict == null)
            return null;

        var keys = new NSString[dict.Count];
        var values = new NSString[dict.Count];
        var index = 0;
        foreach (var entry in dict)
        {
            keys[index] = NSString.FromData(entry.Key, NSStringEncoding.UTF8);
            values[index] = NSString.FromData(entry.Key, NSStringEncoding.UTF8);
            index++;
        }

        var result = new NSDictionary<NSString, NSString>(keys, values);

        return result;
    }
}
