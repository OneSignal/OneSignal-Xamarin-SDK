using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Com.OneSignal.Android;
using Java.Lang;
using OSNotification = Com.OneSignal.Abstractions.OSNotification;
using OSNotificationAction = Com.OneSignal.Abstractions.OSNotificationAction;
using OSNotificationPayload = Com.OneSignal.Abstractions.OSNotificationPayload;

namespace Com.OneSignal
{
    public class NotificationOpenedHandler : Object, Android.OneSignal.INotificationOpenedHandler
    {
        #region INotificationOpenedHandler Members

        public void NotificationOpened(OSNotificationOpenResult result)
        {
            (OneSignal.Current as OneSignalImplementation).onPushNotificationOpened(OSNotificationOpenedResultToNative(result));
        }

        #endregion

        #region Methods

        public static OSNotificationOpenedResult OSNotificationOpenedResultToNative(OSNotificationOpenResult result)
        {
            var actionType = OSNotificationAction.ActionType.Opened;
            if (result.Action.Type == Android.OSNotificationAction.ActionType.Opened)
                actionType = OSNotificationAction.ActionType.Opened;
            else
                actionType = OSNotificationAction.ActionType.ActionTaken;

            var openresult = new OSNotificationOpenedResult();
            openresult.action = new OSNotificationAction();
            var action = result.Action;
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

            notification.payload = TransformPayloadToNative(notif.Payload);

            return notification;
        }

        public static OSNotificationPayload TransformPayloadToNative(Android.OSNotificationPayload androidPayload)
        {
            var payload = new OSNotificationPayload();

            payload.actionButtons = new List<Dictionary<string, object>>();
            if (androidPayload.ActionButtons != null)
            {
                foreach (Android.OSNotificationPayload.ActionButton button in androidPayload.ActionButtons)
                {
                    var d = new Dictionary<string, object>();
                    d.Add(button.Id, button.Text);
                    payload.actionButtons.Add(d);
                }
            }

            payload.additionalData = new Dictionary<string, object>();
            if (androidPayload.AdditionalData != null)
            {
                var iterator = androidPayload.AdditionalData.Keys();
                while (iterator.HasNext)
                {
                    var key = (string)iterator.Next();
                    payload.additionalData.Add(key, androidPayload.AdditionalData.Get(key));
                }
            }

            payload.body = androidPayload.Body;
            payload.launchURL = androidPayload.LaunchURL;
            payload.notificationID = androidPayload.NotificationID;
            payload.sound = androidPayload.Sound;
            payload.title = androidPayload.Title;
            payload.bigPicture = androidPayload.BigPicture;
            payload.fromProjectNumber = androidPayload.FromProjectNumber;
            payload.groupMessage = androidPayload.GroupKey;
            payload.groupMessage = androidPayload.GroupMessage;
            payload.largeIcon = androidPayload.LargeIcon;
            payload.ledColor = androidPayload.LedColor;
            payload.lockScreenVisibility = androidPayload.LockScreenVisibility;
            payload.smallIcon = androidPayload.SmallIcon;
            payload.smallIconAccentColor = androidPayload.SmallIconAccentColor;

            return payload;
        }

        #endregion
    }
}