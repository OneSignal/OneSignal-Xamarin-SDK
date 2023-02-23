namespace OneSignalSDK.Xamarin.Core.Debug;

/// <summary>
/// Access to debug the SDK in the event additional information is required to diagnose any
/// SDK-related issues.
/// </summary>
public interface IDebugManager
{
    /// <summary>
    /// The log level the OneSignal SDK should be writing to the Android log. Defaults to <see cref="LogLevel.WARN"/>.
    /// </summary>
    LogLevel LogLevel { get; set; }

    /// <summary>
    /// The log level the OneSignal SDK should be showing as a modal. Defaults to <see cref="LogLevel.NONE"/>
    /// </summary>
    LogLevel AlertLevel { get; set; }
}