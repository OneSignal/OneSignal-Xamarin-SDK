using System;
using System.Collections.Generic;

using OneSignalSDK.Xamarin.Core;
using OneSignalNative = Com.OneSignal.Android.OneSignal;
using OneSignalAndroid = Com.OneSignal.Android;

namespace OneSignalSDK.Xamarin {
   public static class NativeConversion {

      public static Notification NotificationToXam(OneSignalAndroid.OSNotification notification) {
         Notification nativeNotification = new Notification {
            androidNotificationId = notification.AndroidNotificationId,
            notificationId = notification.NotificationId,
            title = notification.Title,
            body = notification.Body,
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

         if (notification.AdditionalData != null)
            nativeNotification.additionalData = Json.Deserialize(notification.AdditionalData.ToString()) as Dictionary<string, object>;

         if (notification.GroupedNotifications != null) {
            foreach (var individualNotification in notification.GroupedNotifications)
               nativeNotification.groupedNotifications.Add(NotificationToXam(individualNotification));
         }

         if (notification.ActionButtons != null) {
            nativeNotification.actionButtons = new List<ActionButton>();
            foreach (var actionButton in notification.ActionButtons)
               nativeNotification.actionButtons.Add(new ActionButton(actionButton.Id, actionButton.Text, actionButton.Icon));
         }

         if (notification.GetBackgroundImageLayout() != null) {
            nativeNotification.backgroundImageLayout = new BackgroundImageLayout(notification.GetBackgroundImageLayout().Image,
               notification.GetBackgroundImageLayout().TitleTextColor,
               notification.GetBackgroundImageLayout().BodyTextColor);
         }

         return nativeNotification;
      }

      public static InAppMessage InAppMessageToXam(OneSignalAndroid.OSInAppMessage inAppMessage) {
         return new InAppMessage {
            messageId = inAppMessage.MessageId
         };
      }

      public static InAppMessageAction InAppMessageClickedActionToXam(OneSignalAndroid.OSInAppMessageAction action) {
         InAppMessageAction inAppMessageAction = new InAppMessageAction {
            click_name = action.ClickName,
            click_url = action.ClickUrl,
            first_click = action.IsFirstClick,
            closes_message = action.DoesCloseMessage()
         };

         IList<InAppMessageOutcome> outcomes = new List<InAppMessageOutcome>();
         foreach (var outcome in action.Outcomes)
            outcomes.Add(InAppMessageOutcomeToXam(outcome));

         return inAppMessageAction;
      }

      public static NotificationOpenedResult NotificationOpenedResultToXam(OneSignalAndroid.OSNotificationOpenedResult result) {
         return new NotificationOpenedResult {
            notification = NotificationToXam(result.Notification),
            action = NotificationActionToXam(result.Action)
         };

      }

      public static NotificationAction NotificationActionToXam(OneSignalAndroid.OSNotificationAction notificationAction) {
         return new NotificationAction {
            actionID = notificationAction.ActionId,
            type = (NotificationActionType)notificationAction.Type.Ordinal()
         };
      }

      public static InAppMessageOutcome InAppMessageOutcomeToXam(OneSignalAndroid.OSInAppMessageOutcome outcome) {
         return new InAppMessageOutcome {
            name = outcome.Name,
            weight = outcome.Weight,
            unique = outcome.Unique
         };
      }

      public static DeviceState DeviceStateToXam(OneSignalAndroid.OSDeviceState deviceState) {
         return new DeviceState {
            notificationPermission = PermissionStateToXam(deviceState.AreNotificationsEnabled()),
            areNotificationsEnabled = deviceState.AreNotificationsEnabled(),
            isSubscribed = deviceState.IsSubscribed,
            userId = deviceState.UserId,
            pushToken = deviceState.PushToken,
            isPushDisabled = deviceState.IsPushDisabled,
            isEmailSubscribed = deviceState.IsEmailSubscribed,
            emailUserId = deviceState.EmailUserId,
            emailAddress = deviceState.EmailAddress,
            isSMSSubscribed = deviceState.IsSMSSubscribed,
            smsNumber = deviceState.SMSNumber,
            smsUserId = deviceState.SMSUserId
         };
      }

      public static NotificationPermission PermissionStateToXam(bool areNotificationsEnabled) {
         return areNotificationsEnabled ? NotificationPermission.Authorized : NotificationPermission.Denied;
      }

      public static PushSubscriptionState PushSubscriptionStateToXam(OneSignalAndroid.OSSubscriptionState androidSubscriptionState) {
         return new PushSubscriptionState {
            isPushDisabled = androidSubscriptionState.IsPushDisabled,
            pushToken = androidSubscriptionState.PushToken,
            isSubscribed = androidSubscriptionState.IsSubscribed,
            userId = androidSubscriptionState.UserId
         };
      }

      public static EmailSubscriptionState EmailSubscriptionStateToXam(OneSignalAndroid.OSEmailSubscriptionState androidEmailSubscriptionState) {
         return new EmailSubscriptionState {
            emailAddress = androidEmailSubscriptionState.EmailAddress,
            emailUserId = androidEmailSubscriptionState.EmailUserId,
            isSubscribed = androidEmailSubscriptionState.IsSubscribed
         };
      }

      public static SMSSubscriptionState SMSSubscriptionStateToXam(OneSignalAndroid.OSSMSSubscriptionState androidSMSSubscriptionState) {
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

      public static Java.Lang.Object ToJavaObject<TObject>(this TObject value) {
         if (Equals(value, default(TObject)) && !typeof(TObject).IsValueType)
            return null;

         var holder = new JavaHolder(value);

         return holder;
      }

      public class JavaHolder : Java.Lang.Object {
         public readonly object Instance;

         public JavaHolder(object instance) {
            Instance = instance;
         }
      }
   }
}
