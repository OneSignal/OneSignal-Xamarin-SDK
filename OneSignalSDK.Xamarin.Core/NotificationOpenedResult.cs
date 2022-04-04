using System;
namespace OneSignalSDK.Xamarin.Core {
   [Serializable]
   public sealed class NotificationOpenedResult {
      public NotificationAction action;
      public Notification notification;
   }
}
