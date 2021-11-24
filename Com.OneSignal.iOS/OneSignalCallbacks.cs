using System.Collections.Generic;
using System.Diagnostics;

using Laters;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;
using Com.OneSignal.Core;

namespace Com.OneSignal {
   public partial class OneSignalImplementation {
      private delegate void BooleanResponseDelegate(bool response);
      private delegate void StringResponseDelegate(string response);
      private delegate void DictionaryResponseDelegate(string response);

      private interface ICallbackProxy<in TReturn> {
         void OnResponse(TReturn response);
      }

      private abstract class CallbackProxy<TReturn> : BaseLater<TReturn>, ICallbackProxy<TReturn> {
         public abstract void OnResponse(TReturn response);
      }

      private sealed class BooleanCallbackProxy : CallbackProxy<bool> {
         public override void OnResponse(bool response) => _complete(response);
      }

      private sealed class StringCallbackProxy : CallbackProxy<string> {
         public override void OnResponse(string response) => _complete(response);
      }

      private sealed class DictionaryCallbackProxy : CallbackProxy<Dictionary<string, object>> {
         public override void OnResponse(Dictionary<string, object> response) => _complete(response);
      }

      private static OneSignalImplementation _instance;

      public OneSignalImplementation() {
         if (_instance != null) {
            Debug.WriteLine("Additional instance of OneSignalIOS created.");
         }

         OneSignalNative.AddPermissionObserver(new OSPermissionObserver());
         OneSignalNative.AddSubscriptionObserver(new OSSubscriptionObserver());
         OneSignalNative.AddEmailSubscriptionObserver(new OSEmailSubscriptionObserver());
         OneSignalNative.AddSMSSubscriptionObserver(new OSSMSSubscriptionObserver());

         OneSignalNative.SetNotificationWillShowInForegroundHandler(new iOS.OSNotificationWillShowInForegroundBlock(
            (iOS.OSNotification arg0, iOS.OSNotificationDisplayResponse arg1) =>
            new NotificationWillShowInForegroundHandler().NotificationWillShowInForeground(arg0, arg1)));

         OneSignalNative.SetNotificationOpenedHandler(new iOS.OSNotificationOpenedBlock(
            result => new OSNotificationOpenedHandler().NotificationOpened(result)));

         OneSignalNative.SetInAppMessageClickHandler(new iOS.OSInAppMessageClickBlock((iOS.OSInAppMessageAction arg0) =>
         new OSInAppMessageClickHandler().InAppMessageClicked(arg0)));

         OneSignalNative.SetInAppMessageLifecycleHandler(new OSInAppMessageLifeCycleHandler());

         _instance = this;
      }

      private sealed class OSPermissionObserver : iOS.OSPermissionObserver {
         public override void OnOSPermissionChanged(iOS.OSPermissionStateChanges permissionStateChanges) {
            PermissionState from = NativeConversion.PermissionStateToXam(permissionStateChanges.From);
            PermissionState to = NativeConversion.PermissionStateToXam(permissionStateChanges.To);

            _instance.PermissionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSSubscriptionObserver : iOS.OSSubscriptionObserver {
         public override void OnOSSubscriptionChanged(iOS.OSSubscriptionStateChanges stateChanges) {
            PushSubscriptionState from = NativeConversion.SubscriptionStateToXam(stateChanges.From);
            PushSubscriptionState to = NativeConversion.SubscriptionStateToXam(stateChanges.To);

            _instance.PushSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSEmailSubscriptionObserver : iOS.OSEmailSubscriptionObserver {
         public override void OnOSEmailSubscriptionChanged(iOS.OSEmailSubscriptionStateChanges stateChanges) {
            EmailSubscriptionState from = NativeConversion.EmailSubscriptionStateToXam(stateChanges.From);
            EmailSubscriptionState to = NativeConversion.EmailSubscriptionStateToXam(stateChanges.To);

            _instance.EmailSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSSMSSubscriptionObserver : iOS.OSSMSSubscriptionObserver {
         public override void OnOSSMSSubscriptionChanged(iOS.OSSMSSubscriptionStateChanges stateChanges) {
            SMSSubscriptionState from = NativeConversion.SMSSubscriptionStateToXam(stateChanges.From);
            SMSSubscriptionState to = NativeConversion.SMSSubscriptionStateToXam(stateChanges.To);

            _instance.SMSSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class NotificationWillShowInForegroundHandler {
         public void NotificationWillShowInForeground(iOS.OSNotification notification,
            iOS.OSNotificationDisplayResponse notificationDisplayResponse) {
            _instance.NotificationWillShow?.Invoke(NativeConversion.NotificationToXam(notification));
         }
      }

      private sealed class OSNotificationOpenedHandler {
         public void NotificationOpened(iOS.OSNotificationOpenedResult notificationOpenedResult) {
            _instance.NotificationWasOpened?.Invoke(NativeConversion.NotificationOpenedResultToXam(notificationOpenedResult));
         }
      }

      private sealed class OSInAppMessageClickHandler {
         public void InAppMessageClicked(iOS.OSInAppMessageAction inAppMessageAction) {
            _instance.InAppMessageTriggeredAction?.Invoke(NativeConversion.InAppMessageActionToXam(inAppMessageAction));
         }
      }

      private sealed class OSInAppMessageLifeCycleHandler : iOS.OSInAppMessageLifecycleHandler {
         public override void OnWillDisplayInAppMessage(iOS.OSInAppMessage message) {
            _instance.InAppMessageWillDisplay?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnDidDisplayInAppMessage(iOS.OSInAppMessage message) {
            _instance.InAppMessageDidDisplay?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnWillDismissInAppMessage(iOS.OSInAppMessage message) {
            _instance.InAppMessageWillDismiss?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnDidDismissInAppMessage(iOS.OSInAppMessage message) {
            _instance.InAppMessageDidDismiss?.Invoke(NativeConversion.InAppMessageToXam(message));
         }
      }
   }
}
