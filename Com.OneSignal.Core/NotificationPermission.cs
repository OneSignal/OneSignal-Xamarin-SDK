using System;
using System.Collections.Generic;

namespace Com.OneSignal.Core {
   /// <summary>
   /// Status of ability to send push notification as determined by the current user
   /// </summary>
   public enum NotificationPermission {
      /// <summary>The user has not yet made a choice regarding whether your app can show notifications.</summary>
      NotDetermined,

      /// <summary>The application is not authorized to post user notifications.</summary>
      Denied,

      /// <summary>The application is authorized to post user notifications.</summary>
      Authorized,

      /// <summary>The application is only authorized to post Provisional notifications (direct to history)</summary>
      Provisional,

      /// <summary>The application is authorized to send notifications for 8 hours. Only used by App Clips.</summary>
      Ephemeral
   }
}
