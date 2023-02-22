using static System.Net.WebRequestMethods;
using System.Security;
using System.Xml.Linq;
using System;
using System.Threading.Tasks;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// The entry point to the notification SDK for OneSignal.
/// </summary>
public interface INotificationsManager
{
    /// <summary>
    /// Event for when the push permission has changed.
    /// </summary>
    event EventHandler<NotificationPermissionChangedEventArgs> PermissionChanged;

    /// <summary>
    /// Event for when a push notification will display.  The arguments contains
    /// <see cref="NotificationWillDisplayEventArgs.ToDisplayNotification"/> which
    /// will be used to determine whether to display a notification after all
    /// event handlers have been called.
    /// </summary>
    event EventHandler<NotificationWillDisplayEventArgs> WillDisplay;

    /// <summary>
    /// Event for when a push notification has been clicked by the user.
    /// </summary>
    event EventHandler<NotificationClickedEventArgs> Clicked;

    /// <summary>
    /// Whether this app has push notification permission.
    /// </summary>
    bool Permission { get; }

    /// <summary>
    /// Prompt the user for permission to push notifications.  This will display the native
    /// OS prompt to request push notification permission.If the user enables, a push
    /// subscription to this device will be automatically added to the user.
    ///
    /// Be aware of best practices regarding asking permissions on Android:
    /// <a href="https://developer.android.com/guide/topics/permissions/requesting.html">[Requesting Permissions | Android Developers]</a>
    ///
    /// See <a href="https://documentation.onesignal.com/docs/permission-requests">Permission Requests | OneSignal Docs</a>
    /// </summary>
    /// <param name="fallbackToSettings">
    /// Whether to direct the user to this app's settings to drive enabling of notifications,
    /// when the in-app prompting is not possible.
    /// </param>
    /// <returns>
    /// A task which will complete once the permission request has completed. The result
    /// is true if the user is opted in to notifications permission (user affirmed or already enabled),
    /// the result is false if the user is opted out of notifications permission(user rejected).
    /// </returns>
    Task<bool> RequestPermissionAsync(bool fallbackToSettings);
}