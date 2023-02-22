using System;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="INotificationsManager.WillDisplay"/> event.
/// </summary>
public sealed class NotificationWillDisplayEventArgs : EventArgs
{
    /// <summary>
    /// The original notification received by the app.
    /// </summary>
    public Notification OriginalNotification { get; }

    /// <summary>
    /// The notification that is to be displayed by the app.  This should be set to
    /// the <see cref="OriginalNotification"/> when the original notification should
    /// be displayed.  This should be set to <code>null</code> if the notification
    /// should <b>not</b> be displayed by the app.
    /// </summary>
    public Notification? ToDisplayNotification { get; set; }

    public NotificationWillDisplayEventArgs(Notification originalNotification)
    {
        ToDisplayNotification = OriginalNotification = originalNotification;
    }
}
