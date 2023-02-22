using System.Threading.Tasks;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Location;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.Xamarin.Android;

public class AndroidLocationManager : ILocationManager
{
    public bool IsShared
    {
        get => OneSignalNative.Location.Shared;
        set => OneSignalNative.Location.Shared = value;
    }

    public async Task<bool> RequestPermissionAsync()
    {
        var consumer = new AndroidBoolConsumer();
        OneSignalNative.Location.RequestPermission(Com.OneSignal.Android.Continue.With(consumer));
        return await consumer;
    }
}
