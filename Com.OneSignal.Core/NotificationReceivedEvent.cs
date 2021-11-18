using System;
namespace Com.OneSignal.Core {
   public class NotificationReceivedEvent {
        public Notification notificationReceived;

      public NotificationReceivedEvent(Notification notificationReceived) {
            this.notificationReceived = notificationReceived;
      }
   }
}
