using System;
namespace OneSignal.Core {
   [Serializable]
   public sealed class EmailSubscriptionState {
      /// <summary>
      /// Unique id of this subscription
      /// </summary>
      /// <remarks>See https://documentation.onesignal.com/docs/users#player-id for more information</remarks>
      public string emailUserId;

      /// <summary>
      /// Whether this subscription is currently active
      /// </summary>
      public bool isSubscribed;

      /// <summary>
      /// Email address of the user which this subscription was created for
      /// </summary>
      public string emailAddress;
   }
}
