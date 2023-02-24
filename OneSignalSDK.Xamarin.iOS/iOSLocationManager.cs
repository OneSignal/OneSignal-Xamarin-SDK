using System.Threading.Tasks;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Location;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSLocationManager : ILocationManager
{
    public bool IsShared
    {
        get => OneSignalNative.Location.IsShared;
        set => OneSignalNative.Location.SetShared(value);
    }

    public Task<bool> RequestPermissionAsync()
    {
        OneSignalNative.Location.RequestPermission();
        return Task.FromResult(true);
    }
}
