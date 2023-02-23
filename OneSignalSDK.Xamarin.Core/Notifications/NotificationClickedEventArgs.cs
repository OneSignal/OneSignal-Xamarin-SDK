using System;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="INotificationsManager.Clicked"/> event.
/// </summary>
public sealed class NotificationClickedEventArgs : EventArgs
{
    /// <summary>
    /// The notification that was clicked on.
    /// </summary>
    public Notification Notification { get; }

    /// <summary>
    /// The action that was taken on the notification.
    /// </summary>
    public NotificationAction Action { get; }

    public NotificationClickedEventArgs(Notification notification, NotificationAction action)
    {
        Notification = notification;
        Action = action;
    }
}
