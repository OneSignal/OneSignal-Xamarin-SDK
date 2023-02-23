using System;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="INotificationsManager.PermissionChanged"/> event.
/// </summary>
public sealed class NotificationPermissionChangedEventArgs : EventArgs
{
    /// <summary>
    /// The current permission state.
    /// </summary>
    public bool Permission { get; }

    public NotificationPermissionChangedEventArgs(bool permission)
    {
        Permission = permission;
    }
}
