using System.Collections.Generic;
using Foundation;
using OneSignalSDK.Xamarin.Core;
using OneSignaliOS = Com.OneSignal.iOS;

namespace OneSignalSDK.Xamarin {
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

        public static Dictionary<string, string> NSObjectToPureDict(NSObject nSObject) {
            if (nSObject == null)
               return null;
            NSError error;
            NSData jsonData = NSJsonSerialization.Serialize(nSObject, 0, out error);
            NSString jsonNSString = NSString.FromData(jsonData, NSStringEncoding.UTF8);
            string jsonString = jsonNSString.ToString();
            return Json.Deserialize(jsonString) as Dictionary<string, string>;
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

      public static Notification NotificationToXam(OneSignaliOS.OSNotification notification) {
         Dictionary<string, object> additionalDataXam = new Dictionary<string, object>();
         if (notification.AdditionalData != null) {
            additionalDataXam = NSDictToPureDict(notification.AdditionalData);
         }

         List<ActionButton> actionButtonsXam = new List<ActionButton>();
         if(notification.ActionButtons != null) {
            foreach (NSObject actionButton in notification.ActionButtons) {
               Dictionary<string, string> actionButtonXam = NSObjectToPureDict(actionButton);
               if (actionButtonXam != null) {
                  actionButtonsXam.Add(new ActionButton(
                     actionButtonXam.GetValueOrDefault("id"),
                     actionButtonXam.GetValueOrDefault("text"),
                     actionButtonXam.GetValueOrDefault("icon")
                  ));
               }
            }
         }

         return new Notification {
            notificationId = notification.NotificationId,
            templateName = notification.TemplateName,
            templateId = notification.TemplateId,
            title = notification.Title,
            body = notification.Body,
            additionalData = additionalDataXam,
            launchUrl = notification.LaunchURL,
            sound = notification.Sound,
            relevanceScore = notification.RelevanceScore != null ? (float)notification.RelevanceScore : 0,
            rawPayload = notification.RawPayload.ToString(),
            badge = notification.Badge.ToString(),
            badgeIncrement = notification.BadgeIncrement.ToString(),
            actionButtons = actionButtonsXam,
            category = notification.Category,
            threadId = notification.ThreadId,
            subtitle = notification.Subtitle,
            mutableContent = notification.MutableContent,
            contentAvailable = notification.ContentAvailable,
            interruptionLevel = notification.InterruptionLevel
         };
      }

      public static DeviceState DeviceStateToXam(OneSignaliOS.OSDeviceState deviceState) {
         return new DeviceState {
            notificationPermission = (NotificationPermission)deviceState.NotificationPermissionStatus,
            areNotificationsEnabled = deviceState.HasNotificationPermission,
            isSubscribed = deviceState.IsSubscribed,
            userId = deviceState.UserId,
            pushToken = deviceState.PushToken,
            isPushDisabled = deviceState.IsPushDisabled,
            isEmailSubscribed = deviceState.IsEmailSubscribed,
            emailUserId = deviceState.EmailUserId,
            emailAddress = deviceState.EmailAddress,
            isSMSSubscribed = deviceState.IsSMSSubscribed,
            smsNumber = deviceState.SmsNumber,
            smsUserId = deviceState.SmsUserId
         };
      }

      public static NotificationPermission PermissionStateToXam(OneSignaliOS.OSPermissionState permissionState) {
         return (NotificationPermission)permissionState.Status;
      }

      public static PushSubscriptionState SubscriptionStateToXam(OneSignaliOS.OSSubscriptionState subscriptionState) {
         return new PushSubscriptionState {
            isPushDisabled = subscriptionState.IsPushDisabled,
            isSubscribed = subscriptionState.IsSubscribed,
            pushToken = subscriptionState.PushToken,
            userId = subscriptionState.UserId
         };
      }

      public static EmailSubscriptionState EmailSubscriptionStateToXam(OneSignaliOS.OSEmailSubscriptionState emailSubscriptionState) {
         return new EmailSubscriptionState {
            isSubscribed = emailSubscriptionState.IsSubscribed,
            emailAddress = emailSubscriptionState.EmailAddress,
            emailUserId = emailSubscriptionState.EmailUserId
         };
      }

      public static SMSSubscriptionState SMSSubscriptionStateToXam(OneSignaliOS.OSSMSSubscriptionState smsSubscriptionState) {
         return new SMSSubscriptionState {
            isSubscribed = smsSubscriptionState.IsSubscribed,
            smsNumber = smsSubscriptionState.SmsNumber,
            smsUserId = smsSubscriptionState.SmsUserId
         };
      }

      public static NotificationAction NotificationActionToXam(OneSignaliOS.OSNotificationAction notificationAction) {
         return new NotificationAction {
            actionID = notificationAction.ActionId,
            type = (NotificationActionType)notificationAction.Type
         };
      }

      public static NotificationOpenedResult NotificationOpenedResultToXam(OneSignaliOS.OSNotificationOpenedResult notificationOpenedResult) {
         return new NotificationOpenedResult {
            action = NotificationActionToXam(notificationOpenedResult.Action),
            notification = NotificationToXam(notificationOpenedResult.Notification)
         };
      }

      public static InAppMessageAction InAppMessageActionToXam(OneSignaliOS.OSInAppMessageAction inAppMessageAction) {
         return new InAppMessageAction {
            clickName = inAppMessageAction.ClickName,
            clickUrl = inAppMessageAction.ClickUrl?.AbsoluteString,
            closesMessage = inAppMessageAction.ClosesMessage,
            firstClick = inAppMessageAction.FirstClick
         };
      }

      public static InAppMessage InAppMessageToXam(OneSignaliOS.OSInAppMessage inAppMessage) {
         return new InAppMessage {
            messageId = inAppMessage.MessageId
         };
      }
   }
}
