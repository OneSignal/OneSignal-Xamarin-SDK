using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;

namespace Com.OneSignal
{
    public class NotificationOpenedHandler : Java.Lang.Object, Android.OneSignal.INotificationOpenedHandler
    {
        public void NotificationOpened(Android.OSNotificationOpenResult result)
        {
            (OneSignal.Current as OneSignalImplementation).OnPushNotificationOpened(OSNotificationOpenedResultToNative(result));
        }

        public static OSNotificationOpenedResult OSNotificationOpenedResultToNative(Android.OSNotificationOpenResult result)
        {

            OSNotificationAction.ActionType actionType = OSNotificationAction.ActionType.Opened;
            if (result.Action.Type == Android.OSNotificationAction.ActionType.Opened)
                actionType = OSNotificationAction.ActionType.Opened;
            else
                actionType = OSNotificationAction.ActionType.ActionTaken;

            var openresult = new OSNotificationOpenedResult();
            openresult.action = new OSNotificationAction();
            Android.OSNotificationAction action = result.Action;
            openresult.action.actionID = action.ActionID;
            openresult.action.type = actionType;

            openresult.notification = OSNotificationToNative(result.Notification);

            return openresult;
        }

        public static OSNotification OSNotificationToNative(Android.OSNotification notif)
        {
            var notification = new OSNotification();
            notification.shown = notif.Shown;
            notification.androidNotificationId = notif.AndroidNotificationId;
            notif.GroupedNotifications = notif.GroupedNotifications;
            notif.IsAppInFocus = notif.IsAppInFocus;

            notification.payload = new OSNotificationPayload();


            notification.payload.actionButtons = new List<Dictionary<string, object>>();
            if (notif.Payload.ActionButtons != null)
            {
                foreach (Android.OSNotificationPayload.ActionButton button in notif.Payload.ActionButtons)
                {
                    var d = new Dictionary<string, object>();
                    d.Add(button.Id, button.Text);
                    notification.payload.actionButtons.Add(d);
                }
            }

            notification.payload.additionalData = new Dictionary<string, object>();
            if (notif.Payload.AdditionalData != null)
            {
                var iterator = notif.Payload.AdditionalData.Keys();
                while (iterator.HasNext)
                {
                    var key = (string)iterator.Next();
                    notification.payload.additionalData.Add(key, notif.Payload.AdditionalData.Get(key));
                }
            }

            notification.payload.body = notif.Payload.Body;
            notification.payload.launchURL = notif.Payload.LaunchURL;
            notification.payload.notificationID = notif.Payload.NotificationID;
            notification.payload.sound = notif.Payload.Sound;
            notification.payload.title = notif.Payload.Title;
            notification.payload.bigPicture = notif.Payload.BigPicture;
            notification.payload.fromProjectNumber = notif.Payload.FromProjectNumber;
            notification.payload.groupMessage = notif.Payload.GroupKey;
            notification.payload.groupMessage = notif.Payload.GroupMessage;
            notification.payload.largeIcon = notif.Payload.LargeIcon;
            notification.payload.ledColor = notif.Payload.LedColor;
            notification.payload.lockScreenVisibility = notif.Payload.LockScreenVisibility;
            notification.payload.smallIcon = notif.Payload.SmallIcon;
            notification.payload.smallIconAccentColor = notif.Payload.SmallIconAccentColor;

            return notification;
        }
    }
}