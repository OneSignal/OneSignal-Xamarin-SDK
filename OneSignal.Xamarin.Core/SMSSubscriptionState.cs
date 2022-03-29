using System;
namespace OneSignal.Xamarin.Core {
   [Serializable]
   public sealed class SMSSubscriptionState {
      /// <summary>
      /// Unique id of this subscription
      /// </summary>
      /// <remarks>See https://documentation.onesignal.com/docs/users#player-id for more information</remarks>
      public string smsUserId;

      /// <summary>
      /// Whether this subscription is currently active
      /// </summary>
      public bool isSubscribed;

      /// <summary>
      /// Phone number of the user which this subscription was created for
      /// </summary>
      public string smsNumber;
   }
}
