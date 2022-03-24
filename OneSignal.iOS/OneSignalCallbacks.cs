using System.Collections.Generic;
using System.Diagnostics;

using Laters;

using OneSignalNative = Com.OneSignal.iOS.OneSignal;
using OneSignaliOS = Com.OneSignal.iOS;
using OneSignal.Core;

namespace OneSignal {
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

         OneSignalNative.SetNotificationWillShowInForegroundHandler(
            delegate(OneSignaliOS.OSNotification nativeNotification, OneSignaliOS.OSNotificationDisplayResponse response) {
               if (_instance.NotificationWillShow == null) {
                  response.Invoke(nativeNotification);
                  return;
               }

               Notification notification = NativeConversion.NotificationToXam(nativeNotification);
               Notification resultNotif = _instance.NotificationWillShow(notification);
               // OneSignal-iOS-SDK doesn't support modifications to notifications,
               //   null is used to prevent showing.
               response.Invoke(resultNotif != null ? nativeNotification : null);
            }
         );

         OneSignalNative.SetNotificationOpenedHandler(new OneSignaliOS.OSNotificationOpenedBlock(
            result => new OSNotificationOpenedHandler().NotificationOpened(result)));

         OneSignalNative.SetInAppMessageClickHandler(new OneSignaliOS.OSInAppMessageClickBlock((OneSignaliOS.OSInAppMessageAction arg0) =>
         new OSInAppMessageClickHandler().InAppMessageClicked(arg0)));

         OneSignalNative.SetInAppMessageLifecycleHandler(new OSInAppMessageLifeCycleHandler());

         _instance = this;
      }

      private sealed class OSPermissionObserver : OneSignaliOS.OSPermissionObserver {
         public override void OnOSPermissionChanged(OneSignaliOS.OSPermissionStateChanges permissionStateChanges) {
            NotificationPermission from = NativeConversion.PermissionStateToXam(permissionStateChanges.From);
            NotificationPermission to = NativeConversion.PermissionStateToXam(permissionStateChanges.To);

            _instance.PermissionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSSubscriptionObserver : OneSignaliOS.OSSubscriptionObserver {
         public override void OnOSSubscriptionChanged(OneSignaliOS.OSSubscriptionStateChanges stateChanges) {
            PushSubscriptionState from = NativeConversion.SubscriptionStateToXam(stateChanges.From);
            PushSubscriptionState to = NativeConversion.SubscriptionStateToXam(stateChanges.To);

            _instance.PushSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSEmailSubscriptionObserver : OneSignaliOS.OSEmailSubscriptionObserver {
         public override void OnOSEmailSubscriptionChanged(OneSignaliOS.OSEmailSubscriptionStateChanges stateChanges) {
            EmailSubscriptionState from = NativeConversion.EmailSubscriptionStateToXam(stateChanges.From);
            EmailSubscriptionState to = NativeConversion.EmailSubscriptionStateToXam(stateChanges.To);

            _instance.EmailSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSSMSSubscriptionObserver : OneSignaliOS.OSSMSSubscriptionObserver {
         public override void OnOSSMSSubscriptionChanged(OneSignaliOS.OSSMSSubscriptionStateChanges stateChanges) {
            SMSSubscriptionState from = NativeConversion.SMSSubscriptionStateToXam(stateChanges.From);
            SMSSubscriptionState to = NativeConversion.SMSSubscriptionStateToXam(stateChanges.To);

            _instance.SMSSubscriptionStateChanged?.Invoke(to, from);
         }
      }

      private sealed class OSNotificationOpenedHandler {
         public void NotificationOpened(OneSignaliOS.OSNotificationOpenedResult notificationOpenedResult) {
            _instance.NotificationWasOpened?.Invoke(NativeConversion.NotificationOpenedResultToXam(notificationOpenedResult));
         }
      }

      private sealed class OSInAppMessageClickHandler {
         public void InAppMessageClicked(OneSignaliOS.OSInAppMessageAction inAppMessageAction) {
            _instance.InAppMessageTriggeredAction?.Invoke(NativeConversion.InAppMessageActionToXam(inAppMessageAction));
         }
      }

      private sealed class OSInAppMessageLifeCycleHandler : OneSignaliOS.OSInAppMessageLifecycleHandler {
         public override void OnWillDisplayInAppMessage(OneSignaliOS.OSInAppMessage message) {
            _instance.InAppMessageWillDisplay?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnDidDisplayInAppMessage(OneSignaliOS.OSInAppMessage message) {
            _instance.InAppMessageDidDisplay?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnWillDismissInAppMessage(OneSignaliOS.OSInAppMessage message) {
            _instance.InAppMessageWillDismiss?.Invoke(NativeConversion.InAppMessageToXam(message));
         }

         public override void OnDidDismissInAppMessage(OneSignaliOS.OSInAppMessage message) {
            _instance.InAppMessageDidDismiss?.Invoke(NativeConversion.InAppMessageToXam(message));
         }
      }
   }
}
