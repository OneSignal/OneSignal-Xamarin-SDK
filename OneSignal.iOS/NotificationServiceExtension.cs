using System;
using UserNotifications;

using OneSignaliOS = Com.OneSignal.iOS;

namespace OneSignal
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
         return OneSignaliOS.OneSignal.DidReceiveNotificationExtensionRequest(
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
         OneSignaliOS.OneSignal.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
      }
   }
}
