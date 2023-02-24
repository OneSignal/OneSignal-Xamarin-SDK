using Android.Content;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Debug;
using OneSignalSDK.Xamarin.Core.InAppMessages;
using OneSignalSDK.Xamarin.Core.Location;
using OneSignalSDK.Xamarin.Core.Notifications;
using OneSignalSDK.Xamarin.Core.Session;
using OneSignalSDK.Xamarin.Core.User;
using OneSignalSDK.Xamarin.Core.Internal.Utilities;

using Android.App;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.Xamarin.Android;

public class AndroidOneSignal : IOneSignal
{
    public IUserManager User { get; } = new AndroidUserManager();

    public ISessionManager Session { get; } = new AndroidSessionManager();

    public INotificationsManager Notifications { get; } = new AndroidNotificationsManager();

    public ILocationManager Location { get; } = new AndroidLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new AndroidInAppMessagesManager();

    public IDebugManager Debug { get; } = new AndroidDebugManager();

    public bool RequiresPrivacyConsent
    {
        get => OneSignalNative.RequiresPrivacyConsent;
        set => OneSignalNative.RequiresPrivacyConsent = value;
    }

    public bool PrivacyConsent
    {
        get => OneSignalNative.PrivacyConsent;
        set => OneSignalNative.PrivacyConsent = value;
    }

    public void Initialize(string appId)
    {
        Context context = Application.Context;

        Com.OneSignal.Android.Common.OneSignalWrapper.SdkType = WrapperSDK.Type;

        var version = WrapperSDK.Version;
        if (version != null) {
            Com.OneSignal.Android.Common.OneSignalWrapper.SdkVersion = version;
        }

        OneSignalNative.InitWithContext(context, appId);

        ((AndroidUserManager)User).Initialize();
        ((AndroidNotificationsManager)Notifications).Initialize();
        ((AndroidInAppMessagesManager)InAppMessages).Initialize();
    }

    public void Login(string externalId, string? jwtBearerToken = null)
    {
        OneSignalNative.Login(externalId, jwtBearerToken);
    }

    public void Logout()
    {
        OneSignalNative.Logout();
    }
}
