using System.Collections.Generic;
using Foundation;
using Com.OneSignal.Core;

namespace Com.OneSignal {
    public static class NativeConversion {

        public static Dictionary<string, object> NSDictToPureDict(NSDictionary nsDict) {
            if (nsDict == null)
                return null;
            NSError error;
            NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
            NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
            string jsonString = jsonNSString.ToString();
            return Json.Deserialize(jsonString) as Dictionary<string, object>;
        }

        public static string NSDictToString(NSDictionary nsDict) {
            if (nsDict == null)
                return null;
            NSError error;
            NSData jsonData = NSJsonSerialization.Serialize(nsDict, 0, out error);
            NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
            return jsonNSString.ToString();
        }

        public static NSDictionary DictToNSDict(Dictionary<string, object> dict) {
            if (dict == null)
                return null;

            string jsonString = Json.Serialize(dict);
            NSString jsonNSString = new NSString(jsonString);
            NSData jsonData = jsonNSString.Encode(NSStringEncoding.UTF8);
            NSError error;
            NSDictionary nsDict = NSJsonSerialization.Deserialize(jsonData, 0, out error) as NSDictionary;

            return nsDict;
        }

      public static Notification NotificationToNative(iOS.OSNotification notification) {
         return new Notification {
            androidNotificationId = int.Parse(notification.NotificationId),
            groupedNotifications = new List<Notification>(),
            notificationId = notification.NotificationId,
            templateName = notification.TemplateName,
            templateId = notification.TemplateId,
            title = notification.Title,
            body = notification.Body,
            additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as Dictionary<string, object>,
            launchUrl = notification.LaunchURL,
            sound = notification.Sound,
            relevanceScore = (float) notification.RelevanceScore,
            rawPayload = notification.RawPayload.ToString(),
         };
      }

      public static PermissionState PermissionStateToNative(iOS.OSPermissionState permissionState) {
         return new PermissionState {
            hasPrompted = permissionState.HasPrompted,
            status = (NotificationPermission)permissionState.Status
         };
      }

      public static PushSubscriptionState SubscriptionStateToNative(iOS.OSSubscriptionState subscriptionState) {
         return new PushSubscriptionState {
            isPushDisabled = subscriptionState.IsPushDisabled,
            isSubscribed = subscriptionState.IsSubscribed,
            pushToken = subscriptionState.PushToken,
            userId = subscriptionState.UserId
         };
      }

      public static EmailSubscriptionState EmailSubscriptionStateToNative(iOS.OSEmailSubscriptionState emailSubscriptionState) {
         return new EmailSubscriptionState {
            isSubscribed = emailSubscriptionState.IsSubscribed,
            emailAddress = emailSubscriptionState.EmailAddress,
            emailUserId = emailSubscriptionState.EmailUserId
         };
      }

      public static SMSSubscriptionState SMSSubscriptionStateToNative(iOS.OSSMSSubscriptionState smsSubscriptionState) {
         return new SMSSubscriptionState {
            isSubscribed = smsSubscriptionState.IsSubscribed,
            smsNumber = smsSubscriptionState.SmsNumber,
            smsUserId = smsSubscriptionState.SmsUserId
         };
      }

      public static NotificationAction NotificationActionToNative(iOS.OSNotificationAction notificationAction) {
         return new NotificationAction {
            actionID = notificationAction.ActionId,
            type = (NotificationActionType)notificationAction.Type
         };
      }

      public static NotificationOpenedResult NotificationOpenedResultToNative(iOS.OSNotificationOpenedResult notificationOpenedResult) {
         return new NotificationOpenedResult {
            action = NotificationActionToNative(notificationOpenedResult.Action),
            notification = NotificationToNative(notificationOpenedResult.Notification)
         };
      }

      public static InAppMessageAction InAppMessageActionToNative(iOS.OSInAppMessageAction inAppMessageAction) {
         return new InAppMessageAction {
            click_name = inAppMessageAction.ClickName,
            click_url = inAppMessageAction.ClickUrl.AbsoluteString,
            closes_message = inAppMessageAction.ClosesMessage,
            first_click = inAppMessageAction.FirstClick
         };
      }
   }
}
