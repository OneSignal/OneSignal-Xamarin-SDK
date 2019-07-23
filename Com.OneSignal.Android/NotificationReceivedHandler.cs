using System;
namespace Com.OneSignal
{
    public class NotificationReceivedHandler : Java.Lang.Object, Android.OneSignal.INotificationReceivedHandler
    {
        public void NotificationReceived(Android.OSNotification notification)
        {
            (OneSignal.Current as OneSignalImplementation).OnPushNotificationReceived(NotificationOpenedHandler.OSNotificationToNative(notification));
        }
    }
}
