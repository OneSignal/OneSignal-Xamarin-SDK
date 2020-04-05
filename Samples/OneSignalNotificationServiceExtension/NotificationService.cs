using System;
using Foundation;
using UIKit;
using UserNotifications;
using Com.OneSignal;
using Com.OneSignal.Abstractions;

namespace OneSignalNotificationServiceExtension
{
  [Register("NotificationService")]
  public class NotificationService : UNNotificationServiceExtension
  {
    Action<UNNotificationContent> ContentHandler { get; set; }
    UNMutableNotificationContent BestAttemptContent { get; set; }
    UNNotificationRequest ReceivedRequest { get; set; }

    protected NotificationService(IntPtr handle) : base(handle)
    {
      // Note: this .ctor should not contain any initialization logic.
    }

    public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
    {
      ReceivedRequest = request;
      ContentHandler = contentHandler;
      BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();

      (OneSignal.Current as OneSignalImplementation).DidReceiveNotificationExtensionRequest(request, BestAttemptContent);

      ContentHandler(BestAttemptContent);
    }

    public override void TimeWillExpire()
    {
      // Called just before the extension will be terminated by the system.
      // Use this as an opportunity to deliver your "best attempt" at modified content, otherwise the original push payload will be used.

      (OneSignal.Current as OneSignalImplementation).ServiceExtensionTimeWillExpireRequest(ReceivedRequest, BestAttemptContent);

      ContentHandler(BestAttemptContent);
    }
  }
}