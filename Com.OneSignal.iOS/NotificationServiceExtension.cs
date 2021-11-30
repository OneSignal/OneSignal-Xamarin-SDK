using System;
using UserNotifications;

namespace Com.OneSignal
{
   /// <summary>
   /// Public SDK API to be consumed by the App's iOS NotificationServiceExtension target
   /// </summary>
   public partial class OneSignalImplementation
   {
      public UNMutableNotificationContent DidReceiveNotificationExtensionRequest(
         UNNotificationRequest request,
         UNMutableNotificationContent replacementContent,
         Action<UNNotificationContent> contentHandler)
      {
         return iOS.OneSignal.DidReceiveNotificationExtensionRequest(
            request,
            replacementContent,
            delegate (UNNotificationContent notificationContent)
            {
               contentHandler.Invoke(notificationContent);
            }
         );
      }

      public void ServiceExtensionTimeWillExpireRequest(
         UNNotificationRequest request,
         UNMutableNotificationContent replacementContent)
      {
         iOS.OneSignal.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
      }
   }
}
