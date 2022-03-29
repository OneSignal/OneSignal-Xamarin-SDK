using System;
namespace OneSignal.Xamarin.Core {
   [Serializable]
   public sealed class DeviceState {

      public NotificationPermission notificationPermission;

      public bool areNotificationsEnabled;

      public bool isSubscribed;

      public string userId;

      public string pushToken;

      public bool isPushDisabled;

      public bool isEmailSubscribed;

      public string emailUserId;

      public string emailAddress;

      public bool isSMSSubscribed;

      public string smsNumber;

      public string smsUserId;
   }
}
