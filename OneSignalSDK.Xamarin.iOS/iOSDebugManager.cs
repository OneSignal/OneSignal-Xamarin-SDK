using CoreFoundation;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Debug;

using Com.OneSignal.iOS;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSDebugManager : IDebugManager
{
    private Core.Debug.LogLevel _logLevel = Core.Debug.LogLevel.WARN;
    private Core.Debug.LogLevel _alertLevel = Core.Debug.LogLevel.NONE;

    public Core.Debug.LogLevel LogLevel
    {
        get => _logLevel;
        set {
            _logLevel = value;
            OneSignalNative.Debug.SetLogLevel((OneSLogLevel)_logLevel);
        }
    }

    public Core.Debug.LogLevel AlertLevel
    {
        get => _alertLevel;
        set
        {
            _alertLevel = value;
            OneSignalNative.Debug.SetAlertLevel((OneSLogLevel)_alertLevel);
        }
    }
}
