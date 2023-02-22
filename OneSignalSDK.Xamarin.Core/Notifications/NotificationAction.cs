using System;

namespace OneSignalSDK.Xamarin.Core.Notifications;

/// <summary>
/// The type of actions the user can take on a notification.
/// </summary>
public enum NotificationActionType
{
    /// <summary>
    /// Notification was tapped on.
    /// </summary>
    Opened,

    /// <summary>
    /// User tapped on an action from the notification.
    /// </summary>
    ActionTaken
}

/// <summary>
/// The action a user has taken when opening a notification.
/// </summary>
public record NotificationAction
{
    /// <summary>
    /// The type of action the user took on this notification.
    /// </summary>
    public NotificationActionType Type { get; } = NotificationActionType.Opened;

    /// <summary>
    /// When <see cref="Type"/> is <see cref="NotificationActionType.ActionTaken"/>, this will be the custom id of action taken.
    /// See <a href="https://documentation.onesignal.com/docs/action-buttons">Action Buttons | OneSignal Docs</a>.
    /// </summary>
    public string? ActionId { get; }

   public NotificationAction(NotificationActionType type, string? actionId)
   {
      Type = type;
      ActionId = actionId;
   }
}
