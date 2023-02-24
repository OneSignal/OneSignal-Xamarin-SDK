using System;
using System.Security.Permissions;
using System.Threading.Tasks;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.Notifications;
using OneSignalSDK.Xamarin.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSNotificationsManager : INotificationsManager
{
    public event EventHandler<NotificationPermissionChangedEventArgs>? PermissionChanged;
    public event EventHandler<NotificationWillDisplayEventArgs>? WillDisplay;
    public event EventHandler<NotificationClickedEventArgs>? Clicked;

    public bool Permission => OneSignalNative.Notifications.Permission;

    private InternalNotificationsEventsHandler? _notificationsEventsHandler;

    public void Initialize()
    {
        var _notificationsEventsHandler = new InternalNotificationsEventsHandler(this);

        OneSignalNative.Notifications.AddPermissionObserver(_notificationsEventsHandler);
        OneSignalNative.Notifications.SetNotificationWillShowInForegroundHandler(OnNotificationWillShowInForegroundHandler);
        OneSignalNative.Notifications.SetNotificationOpenedHandler(OnNotificationOpenedHandler);
    }

    private void OnNotificationWillShowInForegroundHandler(Com.OneSignal.iOS.OSNotification nativeNotification, Com.OneSignal.iOS.OSNotificationDisplayResponse displayResponse)
    {
        var notification = FromNativeConversion.ToNotification(nativeNotification);
        var args = new NotificationWillDisplayEventArgs(notification);

        WillDisplay?.Invoke(this, args);

        displayResponse.Invoke(args.ToDisplayNotification != null ? nativeNotification : null);
    }

    private void OnNotificationOpenedHandler(Com.OneSignal.iOS.OSNotificationOpenedResult result)
    {
        var notification = FromNativeConversion.ToNotification(result.Notification);
        var action = FromNativeConversion.ToNotificationAction(result.Action);
        var args = new Core.Notifications.NotificationClickedEventArgs(notification, action);
        Clicked?.Invoke(this, args);
    }

    public async Task<bool> RequestPermissionAsync(bool fallbackToSettings)
    {
        var proxy = new BooleanCallbackProxy();
        OneSignalNative.Notifications.RequestPermission(r => proxy.OnResponse(r), fallbackToSettings);
        return await proxy;
    }

    private sealed class InternalNotificationsEventsHandler : Com.OneSignal.iOS.OSPermissionObserver
    {
        private iOSNotificationsManager _manager;
        public InternalNotificationsEventsHandler(iOSNotificationsManager manager)
        {
            _manager = manager;
        }

        public override void OnOSPermissionChanged(Com.OneSignal.iOS.OSPermissionState stateChanges)
        {
            _manager.PermissionChanged?.Invoke(_manager, new NotificationPermissionChangedEventArgs(stateChanges.Permission));
        }
    }
}
