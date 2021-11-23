using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Com.OneSignal.Core;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

using Org.Json;
using Laters;

namespace Com.OneSignal {
   public partial class OneSignalImplementation {
      private class JavaLaterProxy<TResult> : Java.Lang.Object, ILater<TResult> {
         public event Action<TResult> OnComplete {
            add => _later.OnComplete += value;
            remove => _later.OnComplete -= value;
         }

         public TaskAwaiter<TResult> GetAwaiter() {
            return _later.GetAwaiter();
         }

         protected Later<TResult> _later = new Later<TResult>();
      }

      private static OneSignalImplementation _instance;

      public OneSignalImplementation() {
         if (_instance != null) {
            Debug.WriteLine("Additional instance of OneSignalAndroid created.");
         }

         OneSignalNative.AddPermissionObserver(new OSPermissionObserver());
         OneSignalNative.AddSubscriptionObserver(new OSPushSubscriptionObserver());
         OneSignalNative.AddEmailSubscriptionObserver(new OSEmailSubscriptionObserver());
         OneSignalNative.AddSMSSubscriptionObserver(new OSSMSSubscriptionObserver());

         OneSignalNative.SetNotificationWillShowInForegroundHandler(new OSNotificationWillShowInForegroundHandler());
         OneSignalNative.SetNotificationOpenedHandler(new OSNotificationOpenedHandler());
         OneSignalNative.SetInAppMessageClickHandler(new OSInAppMessageClickHandler());
         OneSignalNative.SetInAppMessageLifecycleHandler(new OSInAppMessageLifeCycleHandler());

         _instance = this;
      }

      #region Observers
      private sealed class OSPermissionObserver : Java.Lang.Object, Android.IOSPermissionObserver {
         /// <param name="stateChanges">OSPermissionStateChanges</param>
         public void OnOSPermissionChanged(Android.OSPermissionStateChanges stateChanges) {
            PermissionState prev = NativeConversion.PermissionStateToXam(stateChanges.From);
            PermissionState curr = NativeConversion.PermissionStateToXam(stateChanges.To);
            _instance.PermissionStateChanged?.Invoke(curr, prev);
         }
      }

      private sealed class OSPushSubscriptionObserver : Java.Lang.Object, Android.IOSSubscriptionObserver {
         /// <param name="stateChanges">OnOSSubscriptionChanges</param>
         public void OnOSSubscriptionChanged(Android.OSSubscriptionStateChanges stateChanges) {
            PushSubscriptionState prev = NativeConversion.PushSubscriptionStateToXam(stateChanges.From);
            PushSubscriptionState curr = NativeConversion.PushSubscriptionStateToXam(stateChanges.To);
            _instance.PushSubscriptionStateChanged?.Invoke(curr, prev);
         }
      }

      private sealed class OSEmailSubscriptionObserver : Java.Lang.Object, Android.IOSEmailSubscriptionObserver {
         /// <param name="stateChanges">OnOSEmailSubscriptionChanges</param>
         public void OnOSEmailSubscriptionChanged(Android.OSEmailSubscriptionStateChanges stateChanges) {
            EmailSubscriptionState prev = NativeConversion.EmailSubscriptionStateToXam(stateChanges.From);
            EmailSubscriptionState curr = NativeConversion.EmailSubscriptionStateToXam(stateChanges.To);
            _instance.EmailSubscriptionStateChanged?.Invoke(curr, prev);
         }
      }

      private sealed class OSSMSSubscriptionObserver : Java.Lang.Object, Android.IOSSMSSubscriptionObserver {
         /// <param name="stateChanges">OnSMSSubscriptionChanges</param>
         public void OnSMSSubscriptionChanged(Android.OSSMSSubscriptionStateChanges stateChanges) {
            SMSSubscriptionState prev = NativeConversion.SMSSubscriptionStateToXam(stateChanges.From);
            SMSSubscriptionState curr = NativeConversion.SMSSubscriptionStateToXam(stateChanges.To);
            _instance.SMSSubscriptionStateChanged?.Invoke(curr, prev);
         }
      }
      #endregion

      #region Open and Click Handlers
      private sealed class OSNotificationWillShowInForegroundHandler : Java.Lang.Object, OneSignalNative.IOSNotificationWillShowInForegroundHandler {
         public void NotificationWillShowInForeground(Android.OSNotificationReceivedEvent notificationReceivedEvent) {
            var notifJO = notificationReceivedEvent.Notification;

            if (_instance.NotificationWillShow == null) {
               notificationReceivedEvent.Complete(notifJO);
               return;
            }

            Notification notification = NativeConversion.NotificationToXam(notificationReceivedEvent.Notification);
            Notification resultNotif = _instance.NotificationWillShow(notification);

            notificationReceivedEvent.Complete(resultNotif != null ? notifJO : null);
         }
      }

      private sealed class OSNotificationOpenedHandler : Java.Lang.Object, OneSignalNative.IOSNotificationOpenedHandler {
         public void NotificationOpened(Android.OSNotificationOpenedResult notificationOpenedResult) {
            NotificationOpenedResult result = NativeConversion.NotificationOpenedResultToXam(notificationOpenedResult);
            _instance.NotificationWasOpened?.Invoke(result);
         }
      }

      private sealed class OSInAppMessageClickHandler : Java.Lang.Object, OneSignalNative.IOSInAppMessageClickHandler {
         public void InAppMessageClicked(Android.OSInAppMessageAction inAppMessageAction) {
            InAppMessageAction action = NativeConversion.InAppMessageClickedActionToXam(inAppMessageAction);
            _instance.InAppMessageTriggeredAction?.Invoke(action);
         }
      }

      //private sealed class OSInAppMessageLifeCycleHandler : Android.OSInAppMessageLifecycleHandler {
      //}

      private sealed class OSSMSUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IOSSMSUpdateHandler {
         public void OnSuccess(JSONObject jsonResults) {
            _later.Complete(true);
         }

         public void OnFailure(OneSignalNative.OSSMSUpdateError error) {
            _later.Complete(false);
         }
      }

      private sealed class OSEmailUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IEmailUpdateHandler {
         public void OnSuccess() {
            _later.Complete(true);
         }

         public void OnFailure(OneSignalNative.EmailUpdateError error) {
            _later.Complete(false);
         }
      }

      private sealed class OSGetTagsHandler : JavaLaterProxy<Dictionary<string, object>>, OneSignalNative.IOSGetTagsHandler {
         public void TagsAvailable(JSONObject tags) {
            var result = Json.Deserialize(tags.ToString()) as Dictionary<string, object>;
            _later.Complete(result);
         }
      }

      private sealed class OSExternalUserIDUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IOSExternalUserIdUpdateCompletionHandler {
         public void OnSuccess(JSONObject jsonResults) {
            _later.Complete(true);
         }

         public void OnFailure(OneSignalNative.ExternalIdError error) {
            _later.Complete(false);
         }
      }

      private sealed class OSChangeTagsUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IChangeTagsUpdateHandler {
         public void OnSuccess(JSONObject jsonResults) {
            _later.Complete(true);
         }

         public void OnFailure(OneSignalNative.SendTagsError error) {
            _later.Complete(false);
         }
      }

      private sealed class OSOutcomeCallback : JavaLaterProxy<bool>, OneSignalNative.IOutcomeCallback {
         public void OnSuccess(Android.OSOutcomeEvent outcome) {
            _later.Complete(true);
         }

         public void OnFailure(OneSignalNative.SendTagsError error) {
            _later.Complete(false);
         }
      }

      private sealed class OSPostNotificationResponseHandler : JavaLaterProxy<bool>, OneSignalNative.IPostNotificationResponseHandler {
         public void OnSuccess(JSONObject jsonResults) {
            _later.Complete(true);
         }

         public void OnFailure(JSONObject error) {
            _later.Complete(false);
         }
      }
      #endregion
   }
}
