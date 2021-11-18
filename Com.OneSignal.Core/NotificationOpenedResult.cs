using System;
namespace Com.OneSignal.Core {
    public class NotificationOpenedResult {
        public NotificationAction action;
        public Notification notification;

        public NotificationOpenedResult(Notification notification, NotificationAction action) {
            this.notification = notification;
            this.action = action;
        }
    }
}
