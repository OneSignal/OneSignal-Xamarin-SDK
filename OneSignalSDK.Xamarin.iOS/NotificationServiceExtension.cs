using System;
using UserNotifications;

using OneSignalNative = Com.OneSignal.iOS;

namespace OneSignalSDK.Xamarin.iOS
{
    /// <summary>
    /// Public SDK API to be consumed by the App's iOS NotificationServiceExtension target.
    /// </summary>
    public static class NotificationServiceExtension
    {
        /// <summary>
        /// Should be called in your <see cref="UNNotificationServiceExtension.DidReceiveNotificationRequest(UNNotificationRequest, Action{UNNotificationContent})"/>.
        /// </summary>
        /// <param name="request">The notification request.</param>
        /// <param name="replacementContent">The notification content.</param>
        /// <param name="contentHandler">A content handler.</param>
        /// <returns>The notification content.</returns>
        public static UNMutableNotificationContent DidReceiveNotificationExtensionRequest(
           UNNotificationRequest request,
           UNMutableNotificationContent replacementContent,
           Action<UNNotificationContent> contentHandler)
        {
            return OneSignalNative.OneSignal.DidReceiveNotificationExtensionRequest(
               request,
               replacementContent,
               delegate (UNNotificationContent notificationContent)
               {
                   contentHandler.Invoke(notificationContent);
               }
            );
        }

        /// <summary>
        /// Should be called in your <see cref="UNNotificationServiceExtension.TimeWillExpire"/>.
        /// </summary>
        /// <param name="request">The notification request.</param>
        /// <param name="replacementContent">The notification content.</param>
        public static void ServiceExtensionTimeWillExpireRequest(
           UNNotificationRequest request,
           UNMutableNotificationContent replacementContent)
        {
            OneSignalNative.OneSignal.ServiceExtensionTimeWillExpireRequest(request, replacementContent);
        }
    }
}
