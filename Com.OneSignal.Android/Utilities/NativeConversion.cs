using System;
using System.Collections.Generic;

using Com.OneSignal.Core;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace Com.OneSignal {
   public static class NativeConversion {

      public static Notification NotificationToNative(Android.OSNotification notification) {
         Notification nativeNotification = new Notification {
            androidNotificationId = notification.AndroidNotificationId,
            groupedNotifications = new List<Notification>(),
            notificationId = notification.NotificationId,
            templateName = notification.TemplateName,
            templateId = notification.TemplateId,
            title = notification.Title,
            body = notification.Body,
            additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as Dictionary<string, object>,
            smallIcon = notification.SmallIcon,
            largeIcon = notification.LargeIcon,
            bigPicture = notification.BigPicture,
            smallIconAccentColor = notification.SmallIconAccentColor,
            launchUrl = notification.LaunchURL,
            sound = notification.Sound,
            ledColor = notification.LedColor,
            lockScreenVisibility = notification.LockScreenVisibility,
            fromProjectNumber = notification.FromProjectNumber,
            groupKey = notification.GroupKey,
            groupMessage = notification.GroupMessage,
            CollapseId = notification.CollapseId,
            priority = notification.Priority,
            rawPayload = notification.RawPayload,
         };
         foreach (var individualNotification in notification.GroupedNotifications)
            nativeNotification.groupedNotifications.Add(NotificationToNative(individualNotification));

         nativeNotification.actionButtons = new List<ActionButton>();
         foreach (var actionButton in notification.ActionButtons)
            nativeNotification.actionButtons.Add(new ActionButton(actionButton.Id, actionButton.Text, actionButton.Icon));

         nativeNotification.backgroundImageLayout = new BackgroundImageLayout(notification.GetBackgroundImageLayout().Image,
            notification.GetBackgroundImageLayout().TitleTextColor,
            notification.GetBackgroundImageLayout().BodyTextColor);

         return nativeNotification;
      }

      public static InAppMessageAction OSInAppMessageClickedActionToNative(Android.OSInAppMessageAction action) {
         InAppMessageAction inAppMessageAction = new InAppMessageAction();
         inAppMessageAction.click_name = action.ClickName;
         inAppMessageAction.click_url = action.ClickUrl;
         inAppMessageAction.first_click = action.IsFirstClick;
         inAppMessageAction.closes_message = action.DoesCloseMessage();

         IList<InAppMessageOutcome> outcomes = new List<InAppMessageOutcome>();
         foreach (var outcome in action.Outcomes)
            outcomes.Add(InAppMessageOutcomeToNative(outcome));

         IList<InAppMessagePrompt> prompts = new List<InAppMessagePrompt>();
         foreach (var prompt in action.Prompts)
            prompts.Add(InAppMessagePromptToNative(prompt));

         return inAppMessageAction;
      }

      public static NotificationOpenedResult NotificationOpenedResultToNative(Android.OSNotificationOpenedResult result) {
         NotificationOpenedResult notificationOpenedResult = new NotificationOpenedResult();
         notificationOpenedResult.notification = NotificationToNative(result.Notification);
         notificationOpenedResult.action = NotificationActionToNative(result.Action);

         return notificationOpenedResult;
      }

      public static NotificationAction NotificationActionToNative(Android.OSNotificationAction notificationAction) {
         NotificationAction action = new NotificationAction();
         action.actionID = notificationAction.ActionId;
         action.type = (NotificationActionType)notificationAction.Type.Ordinal();
         return action;
      }

      public static InAppMessageOutcome InAppMessageOutcomeToNative(Android.OSInAppMessageOutcome outcome) {
         InAppMessageOutcome inAppMessageOutcome = new InAppMessageOutcome {
            name = outcome.Name,
            weight = outcome.Weight,
            unique = outcome.Unique
         };
         return inAppMessageOutcome;
      }

      public static InAppMessagePrompt InAppMessagePromptToNative(Android.OSInAppMessagePrompt prompt) {
         InAppMessagePrompt inAppMessagePrompt = new InAppMessagePrompt {
            //prompted = prompt.HasPrompted
         };
         return inAppMessagePrompt;
      }

      public static PermissionState PermissionStateToNative(Android.OSPermissionState androidPermissionState) {
         PermissionState permissionState = new PermissionState();
         permissionState.status = androidPermissionState.AreNotificationsEnabled()? NotificationPermission.Authorized : NotificationPermission.Denied;
         return permissionState;
      }

      public static PushSubscriptionState PushSubscriptionStateToNative(Android.OSSubscriptionState androidSubscriptionState) {
         PushSubscriptionState subscriptionState = new PushSubscriptionState();
         subscriptionState.isPushDisabled = androidSubscriptionState.IsPushDisabled;
         subscriptionState.pushToken = androidSubscriptionState.PushToken;
         subscriptionState.isSubscribed = androidSubscriptionState.IsSubscribed;
         subscriptionState.userId = androidSubscriptionState.UserId;
         return subscriptionState;
      }

      public static EmailSubscriptionState EmailSubscriptionStateToNative(Android.OSEmailSubscriptionState androidEmailSubscriptionState) {
         EmailSubscriptionState emailSubscriptionState = new EmailSubscriptionState();
         emailSubscriptionState.emailAddress = androidEmailSubscriptionState.EmailAddress;
         emailSubscriptionState.emailUserId = androidEmailSubscriptionState.EmailUserId;
         emailSubscriptionState.isSubscribed = androidEmailSubscriptionState.IsSubscribed;
         return emailSubscriptionState;
      }

      public static SMSSubscriptionState SMSSubscriptionStateToNative(Android.OSSMSSubscriptionState androidSMSSubscriptionState) {
         SMSSubscriptionState smsSubscriptionState = new SMSSubscriptionState();
         smsSubscriptionState.smsNumber = androidSMSSubscriptionState.SMSNumber;
         smsSubscriptionState.smsUserId = androidSMSSubscriptionState.SMSNumber;
         smsSubscriptionState.isSubscribed = androidSMSSubscriptionState.IsSubscribed;
         return smsSubscriptionState;
      }

      //public static InAppMessageTag InAppMessageTagToNative(Android.OSInAppMessageTag tag) {
      //   InAppMessageTag inAppMessageTag = new InAppMessageTag {
      //      // tagsToAdd = tag.TagsToAdd,
      //      //tagsToRemove = tag.TagsToRemove
      //   };
      //   return inAppMessageTag;
      //}

      public static OneSignalNative.LOG_LEVEL LogConversion(LogType logLevel) {
         switch (logLevel) {
            case LogType.NONE:
               return OneSignalNative.LOG_LEVEL.None;
            case LogType.FATAL:
               return OneSignalNative.LOG_LEVEL.Fatal;
            case LogType.ERROR:
               return OneSignalNative.LOG_LEVEL.Error;
            case LogType.WARN:
               return OneSignalNative.LOG_LEVEL.Warn;
            case LogType.INFO:
               return OneSignalNative.LOG_LEVEL.Info;
            case LogType.DEBUG:
               return OneSignalNative.LOG_LEVEL.Debug;
            case LogType.VERBOSE:
               return OneSignalNative.LOG_LEVEL.Debug;
            default:
               return OneSignalNative.LOG_LEVEL.None;
         }

      }
   }
}
