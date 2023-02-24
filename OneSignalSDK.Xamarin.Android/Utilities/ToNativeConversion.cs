using System;
using OneSignalSDK.Xamarin.Core.Debug;

namespace OneSignalSDK.Xamarin.Android.Utilities;

/// <summary>
/// Translation functions when translating from .NET SDK class types to their respective native SDK class types.
/// </summary>
public static class ToNativeConversion
{
    public static Com.OneSignal.Android.Debug.LogLevel ToLogLevel(LogLevel logLevel)
    {
        switch (logLevel)
        {
            case LogLevel.NONE:
                return Com.OneSignal.Android.Debug.LogLevel.None!;
            case LogLevel.FATAL:
                return Com.OneSignal.Android.Debug.LogLevel.Fatal!;
            case LogLevel.ERROR:
                return Com.OneSignal.Android.Debug.LogLevel.Error!;
            case LogLevel.WARN:
                return Com.OneSignal.Android.Debug.LogLevel.Warn!;
            case LogLevel.INFO:
                return Com.OneSignal.Android.Debug.LogLevel.Info!;
            case LogLevel.DEBUG:
                return Com.OneSignal.Android.Debug.LogLevel.Debug!;
            case LogLevel.VERBOSE:
                return Com.OneSignal.Android.Debug.LogLevel.Verbose!;
            default:
                return Com.OneSignal.Android.Debug.LogLevel.None!;
        }
    }

    public static Java.Lang.Object? ToJavaObject<TObject>(this TObject value)
    {
        if (Equals(value, default(TObject)) && !typeof(TObject).IsValueType)
            return null;

        if (value is string strValue)
        {
            return new Java.Lang.String(strValue);
        }
        else if (value is int intValue)
        {
            return new Java.Lang.Integer(intValue);
        }
        else if (value is long longValue)
        {
            return new Java.Lang.Long(longValue);
        }
        else if (value is float floatValue)
        {
            return new Java.Lang.Float(floatValue);
        }
        else if (value is double doubleValue)
        {
            return new Java.Lang.Double(doubleValue);
        }
        else if (value is short shortValue)
        {
            return new Java.Lang.Short(shortValue);
        }
        else if (value is char charValue)
        {
            return new Java.Lang.Character(charValue);
        }
        else if (value is sbyte byteValue)
        {
            return new Java.Lang.Byte(byteValue);
        }
        else if (value is uint uintValue)
        {
            return new Java.Lang.Integer((int)uintValue);
        }
        else if (value is ulong ulongValue)
        {
            return new Java.Lang.Long((long)ulongValue);
        }

        return null;
    }
}
