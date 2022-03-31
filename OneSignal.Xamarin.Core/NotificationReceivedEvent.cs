using System;
namespace OneSignal.Xamarin.Core {
   public class NotificationReceivedEvent {
        public Notification notificationReceived;

      public NotificationReceivedEvent(Notification notificationReceived) {
            this.notificationReceived = notificationReceived;
      }
   }
}
