using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Session;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.Xamarin.Android;

public class AndroidSessionManager : ISessionManager
{
    public void AddOutcome(string name) => OneSignalNative.Session.AddOutcome(name);
    public void AddUniqueOutcome(string name) => OneSignalNative.Session.AddUniqueOutcome(name);
    public void AddOutcomeWithValue(string name, float value) => OneSignalNative.Session.AddOutcomeWithValue(name, value);
}
