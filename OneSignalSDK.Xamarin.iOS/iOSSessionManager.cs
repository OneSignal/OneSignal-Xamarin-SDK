using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Session;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSSessionManager : ISessionManager
{
    public void AddOutcome(string name) => OneSignalNative.Session.AddOutcome(name);
    public void AddUniqueOutcome(string name) => OneSignalNative.Session.AddUniqueOutcome(name);
    public void AddOutcomeWithValue(string name, float value) => OneSignalNative.Session.AddOutcomeWithValue(name, value);
}
