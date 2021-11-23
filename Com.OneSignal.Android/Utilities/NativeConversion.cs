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
         InAppMessageAction inAppMessageAction = new InAppMessageAction {
            click_name = action.ClickName,
            click_url = action.ClickUrl,
            first_click = action.IsFirstClick,
            closes_message = action.DoesCloseMessage()
         };

         IList<InAppMessageOutcome> outcomes = new List<InAppMessageOutcome>();
         foreach (var outcome in action.Outcomes)
            outcomes.Add(InAppMessageOutcomeToNative(outcome));

         return inAppMessageAction;
      }

      public static NotificationOpenedResult NotificationOpenedResultToNative(Android.OSNotificationOpenedResult result) {
         return new NotificationOpenedResult {
            notification = NotificationToNative(result.Notification),
            action = NotificationActionToNative(result.Action)
         };

      }

      public static NotificationAction NotificationActionToNative(Android.OSNotificationAction notificationAction) {
         return new NotificationAction {
            actionID = notificationAction.ActionId,
            type = (NotificationActionType)notificationAction.Type.Ordinal()
         };
      }

      public static InAppMessageOutcome InAppMessageOutcomeToNative(Android.OSInAppMessageOutcome outcome) {
         return new InAppMessageOutcome {
            name = outcome.Name,
            weight = outcome.Weight,
            unique = outcome.Unique
         };
      }

      public static PermissionState PermissionStateToNative(Android.OSPermissionState androidPermissionState) {
         return new PermissionState {
            status = androidPermissionState.AreNotificationsEnabled() ? NotificationPermission.Authorized : NotificationPermission.Denied
         };
      }

      public static PushSubscriptionState PushSubscriptionStateToNative(Android.OSSubscriptionState androidSubscriptionState) {
         return new PushSubscriptionState {
            isPushDisabled = androidSubscriptionState.IsPushDisabled,
            pushToken = androidSubscriptionState.PushToken,
            isSubscribed = androidSubscriptionState.IsSubscribed,
            userId = androidSubscriptionState.UserId
         };
      }

      public static EmailSubscriptionState EmailSubscriptionStateToNative(Android.OSEmailSubscriptionState androidEmailSubscriptionState) {
         return new EmailSubscriptionState {
            emailAddress = androidEmailSubscriptionState.EmailAddress,
            emailUserId = androidEmailSubscriptionState.EmailUserId,
            isSubscribed = androidEmailSubscriptionState.IsSubscribed
         };
      }

      public static SMSSubscriptionState SMSSubscriptionStateToNative(Android.OSSMSSubscriptionState androidSMSSubscriptionState) {
         return new SMSSubscriptionState {
            smsNumber = androidSMSSubscriptionState.SMSNumber,
            smsUserId = androidSMSSubscriptionState.SMSNumber,
            isSubscribed = androidSMSSubscriptionState.IsSubscribed
         };
      }

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
