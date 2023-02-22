using System;
using System.Collections.Generic;
using OneSignalSDK.Xamarin.Core.Debug;
using OneSignalSDK.Xamarin.Core.InAppMessages;
using OneSignalSDK.Xamarin.Core.Notifications;
using OneSignalSDK.Xamarin.Core.Internal.Utilities;

namespace OneSignalSDK.Xamarin.Android.Utilities;

/// <summary>
/// Translation functions when translating from native SDK class types to their respective .NET SDK class types.
/// </summary>
public static class FromNativeConversion
{
    public static Core.Notifications.Notification ToNotification(Com.OneSignal.Android.Notifications.INotification notification)
    {
        IDictionary<string, object> additionalData = new Dictionary<string, object>();
        if (notification.AdditionalData != null)
            additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as IDictionary<string, object> ?? new Dictionary<string, object>();

        IList<Core.Notifications.Notification>? groupedNotifications = null;
        if (notification.GroupedNotifications != null)
        {
            groupedNotifications = new List<Core.Notifications.Notification>();
            foreach (var individualNotification in notification.GroupedNotifications)
                groupedNotifications.Add(ToNotification(individualNotification));
        }

        var actionButtons = new List<Core.Notifications.ActionButton>();
        if (notification.ActionButtons != null)
        {
            foreach (var actionButton in notification.ActionButtons)
                actionButtons.Add(new Core.Notifications.ActionButton(
                    id: actionButton.Id,
                    text: actionButton.Text,
                    icon: actionButton.Icon
                ));
        }

        Core.Notifications.BackgroundImageLayout? backgroundImageLayout = null;
        if (notification.BackgroundImageLayout != null)
        {
            backgroundImageLayout = new Core.Notifications.BackgroundImageLayout(
                image: notification.BackgroundImageLayout.Image,
                titleTextColor: notification.BackgroundImageLayout.TitleTextColor,
                bodyTextColor: notification.BackgroundImageLayout.BodyTextColor
            );
        }

        return new Core.Notifications.Notification(
            title: notification.Title,
            body: notification.Body,
            sound: notification.Sound,
            launchUrl: notification.LaunchURL,
            actionButtons: actionButtons,
            additionalData: additionalData,
            notificationId: notification.NotificationId,
            groupedNotifications: groupedNotifications,
            backgroundImageLayout: backgroundImageLayout,
            groupKey: notification.GroupKey,
            groupMessage: notification.GroupMessage,
            ledColor: notification.LedColor,
            priority: notification.Priority,
            smallIcon: notification.SmallIcon,
            largeIcon: notification.LargeIcon,
            bigPicture: notification.BigPicture,
            collapseId: notification.CollapseId,
            fromProjectNumber: notification.FromProjectNumber,
            smallIconAccentColor: notification.SmallIconAccentColor,
            lockScreenVisibility: notification.LockScreenVisibility,
            androidNotificationId: notification.AndroidNotificationId
        );
    }

    public static Core.Notifications.NotificationActionType ToNotificationActionType(Com.OneSignal.Android.Notifications.NotificationActionActionType actionType)
    {
        return (Core.Notifications.NotificationActionType)actionType.Ordinal();
    }

    public static InAppMessage ToInAppMessage(Com.OneSignal.Android.InAppMessages.IInAppMessage inAppMessage)
    {
        return new InAppMessage(
           messageId: inAppMessage.MessageId
        );
    }

    public static InAppMessageAction ToInAppMessageAction(Com.OneSignal.Android.InAppMessages.IInAppMessageAction inAppMessageAction)
    {
        return new InAppMessageAction(
            clickName: inAppMessageAction.ClickName,
            clickUrl: inAppMessageAction.ClickUrl,
            isFirstClick: inAppMessageAction.IsFirstClick,
            closesMessage: inAppMessageAction.ClosesMessage
        );
    }
}
