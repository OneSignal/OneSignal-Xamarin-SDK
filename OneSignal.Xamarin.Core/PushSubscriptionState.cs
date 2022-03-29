using System;
namespace OneSignal.Xamarin.Core {
   [Serializable]
   public sealed class PushSubscriptionState {
      /// <summary>
      /// Unique id of this subscription
      /// </summary>
      /// <remarks>See https://documentation.onesignal.com/docs/users#player-id for more information</remarks>
      public string userId;

      /// <summary>
      /// Whether this subscription is currently active
      /// </summary>
      public bool isSubscribed;

      /// <summary>
      /// The unique token provided by the device's operating system used to send push notifications
      /// </summary>
      public string pushToken;

      public bool isPushDisabled;
   }
}
