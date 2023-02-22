using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Debug;
using OneSignalSDK.Xamarin.Core.InAppMessages;
using OneSignalSDK.Xamarin.Core.Location;
using OneSignalSDK.Xamarin.Core.Notifications;
using OneSignalSDK.Xamarin.Core.Session;
using OneSignalSDK.Xamarin.Core.User;
using OneSignalSDK.Xamarin.Core.Internal.Utilities;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;
using Foundation;
using System;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSOneSignal : IOneSignal
{
    public IUserManager User { get; } = new iOSUserManager();

    public ISessionManager Session { get; } = new iOSSessionManager();

    public INotificationsManager Notifications { get; } = new iOSNotificationsManager();

    public ILocationManager Location { get; } = new iOSLocationManager();

    public IInAppMessagesManager InAppMessages { get; } = new iOSInAppMessagesManager();

    public IDebugManager Debug { get; } = new iOSDebugManager();

    public bool RequiresPrivacyConsent
    {
        get => OneSignalNative.RequiresPrivacyConsent;
        set => OneSignalNative.RequiresPrivacyConsent = value;
    }

    public bool PrivacyConsent
    {
        get => OneSignalNative.PrivacyConsent;
        set => OneSignalNative.SetPrivacyConsent(value);
    }

    public void Initialize(string appId)
    {
        Com.OneSignal.iOS.OneSignalWrapper.SdkType = WrapperSDK.Type;

        var version = WrapperSDK.Version;
        if (version != null)
        {
            Com.OneSignal.iOS.OneSignalWrapper.SdkVersion = version;
        }

        OneSignalNative.Initialize(appId, new NSDictionary());

        ((iOSUserManager)User).Initialize();
        ((iOSNotificationsManager)Notifications).Initialize();
        ((iOSInAppMessagesManager)InAppMessages).Initialize();
    }

    public void Login(string externalId, string? jwtBearerToken = null)
    {
        if (String.IsNullOrWhiteSpace(jwtBearerToken))
        {
            OneSignalNative.Login(externalId);
        }
        else
        {
            OneSignalNative.Login(externalId, jwtBearerToken);
        }
    }

    public void Logout()
    {
        OneSignalNative.Logout();
    }
}
