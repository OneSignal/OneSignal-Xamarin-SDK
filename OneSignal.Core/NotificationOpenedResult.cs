using System;
namespace OneSignal.Core {
   [Serializable]
   public sealed class NotificationOpenedResult {
      public NotificationAction action;
      public Notification notification;
   }
}
