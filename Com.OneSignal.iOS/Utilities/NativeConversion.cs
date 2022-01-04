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

      public static Notification NotificationToXam(iOS.OSNotification iosNotification) {
         var notification = new Notification {
            notificationId = iosNotification.NotificationId,
            templateName = iosNotification.TemplateName,
            templateId = iosNotification.TemplateId,
            title = iosNotification.Title,
            body = iosNotification.Body,
            launchUrl = iosNotification.LaunchURL,
            sound = iosNotification.Sound,
            rawPayload = iosNotification.RawPayload?.ToString(),
         };

         if (iosNotification.AdditionalData != null)
         {
            notification.additionalData = Json.Deserialize(iosNotification.AdditionalData.ToString()) as Dictionary<string, object>;
         }

         if (iosNotification.RelevanceScore != null)
         {
            notification.relevanceScore = (float)iosNotification.RelevanceScore;
         }

         return notification;
      }

      public static PermissionState PermissionStateToXam(iOS.OSPermissionState permissionState) {
         return new PermissionState {
            hasPrompted = permissionState.HasPrompted,
            status = (NotificationPermission)permissionState.Status
         };
      }

      public static PushSubscriptionState SubscriptionStateToXam(iOS.OSSubscriptionState subscriptionState) {
         return new PushSubscriptionState {
            isPushDisabled = subscriptionState.IsPushDisabled,
            isSubscribed = subscriptionState.IsSubscribed,
            pushToken = subscriptionState.PushToken,
            userId = subscriptionState.UserId
         };
      }

      public static EmailSubscriptionState EmailSubscriptionStateToXam(iOS.OSEmailSubscriptionState emailSubscriptionState) {
         return new EmailSubscriptionState {
            isSubscribed = emailSubscriptionState.IsSubscribed,
            emailAddress = emailSubscriptionState.EmailAddress,
            emailUserId = emailSubscriptionState.EmailUserId
         };
      }

      public static SMSSubscriptionState SMSSubscriptionStateToXam(iOS.OSSMSSubscriptionState smsSubscriptionState) {
         return new SMSSubscriptionState {
            isSubscribed = smsSubscriptionState.IsSubscribed,
            smsNumber = smsSubscriptionState.SmsNumber,
            smsUserId = smsSubscriptionState.SmsUserId
         };
      }

      public static NotificationAction NotificationActionToXam(iOS.OSNotificationAction notificationAction) {
         return new NotificationAction {
            actionID = notificationAction.ActionId,
            type = (NotificationActionType)notificationAction.Type
         };
      }

      public static NotificationOpenedResult NotificationOpenedResultToXam(iOS.OSNotificationOpenedResult notificationOpenedResult) {
         return new NotificationOpenedResult {
            action = NotificationActionToXam(notificationOpenedResult.Action),
            notification = NotificationToXam(notificationOpenedResult.Notification)
         };
      }

      public static InAppMessageAction InAppMessageActionToXam(iOS.OSInAppMessageAction inAppMessageAction) {
         return new InAppMessageAction {
            click_name = inAppMessageAction.ClickName,
            click_url = inAppMessageAction.ClickUrl?.AbsoluteString,
            closes_message = inAppMessageAction.ClosesMessage,
            first_click = inAppMessageAction.FirstClick
         };
      }

      public static InAppMessage InAppMessageToXam(iOS.OSInAppMessage inAppMessage) {
         return new InAppMessage {
            messageId = inAppMessage.MessageId
         };
      }
   }
}
