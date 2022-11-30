﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;
using OneSignalSDK.Xamarin;

namespace OneSignalSDK.Xamarin.Core {
   public abstract partial class OneSignalSDKInternal {
      public static OneSignalSDKInternal _default;

      public static OneSignalSDKInternal _getDefaultInstance() {
         if (_default != null)
            return _default;

         return _default;
      }

      #region Delegate Definitions
      /// <summary>
      /// When a push notification has been received and is about to be displayed
      /// </summary>
      /// <param name="notification">Details of the notification to be shown</param>
      /// <returns>The notification object or null if the notification should not be displayed</returns>
      public delegate Notification NotificationWillShowDelegate(Notification notification);

      /// <summary>
      /// When a push notification was acted on by the user.
      /// </summary>
      /// <param name="result">The Notification open result describing:
      ///     1. The notification opened
      ///     2. The action taken by the user.
      /// </param>
      public delegate void NotificationActionDelegate(NotificationOpenedResult result);

      /// <summary>
      /// When any client side event in an In-App Message's occurs there will be a corresponding event with this
      /// delegate signature.
      /// </summary>
      public delegate void InAppMessageLifecycleDelegate(InAppMessage message);

      /// <summary>
      /// Sets a In App Message opened handler. The instance will be called when an In App Message action is tapped on.
      /// </summary>
      public delegate void InAppMessageActionDelegate(InAppMessageAction action);

      /// <summary>
      /// Several states associated with the SDK can be changed can be changed in and outside of the application.
      /// </summary>
      public delegate void StateChangeDelegate<in TState>(TState current, TState previous);
      #endregion

      #region Events
      /// <summary>
      /// When an push notification has been received
      /// </summary>
      public abstract event NotificationWillShowDelegate NotificationWillShow;

      /// <summary>
      /// When a push notification has been opened by the user
      /// </summary>
      public abstract event NotificationActionDelegate NotificationOpened;

      /*
       * In App Messages 
       */

      /// <summary>
      /// When a user has chosen to dismiss an In-App Message
      /// </summary>
      public abstract event InAppMessageLifecycleDelegate InAppMessageWillDisplay;

      /// <summary>
      /// When an In-App Message is has been displayed to the screen
      /// </summary>
      public abstract event InAppMessageLifecycleDelegate InAppMessageDidDisplay;

      /// <summary>
      /// When a user has chosen to dismiss an In-App Message
      /// </summary>
      public abstract event InAppMessageLifecycleDelegate InAppMessageWillDismiss;

      /// <summary>
      /// When an In-App Message has finished being dismissed
      /// </summary>
      public abstract event InAppMessageLifecycleDelegate InAppMessageDidDismiss;

      /// <summary>
      /// When a user has triggered an action attached to an In-App Message
      /// </summary>
      public abstract event InAppMessageActionDelegate InAppMessageTriggeredAction;
      #endregion

      #region States
      /// <summary>
      /// When this device's permissions for authorization of push notifications have changed.
      /// </summary>
      public abstract event StateChangeDelegate<NotificationPermission> NotificationPermissionChanged;

      /// <summary>
      /// When this device's subscription to push notifications has changed
      /// </summary>
      public abstract event StateChangeDelegate<PushSubscriptionState> PushSubscriptionStateChanged;

      /// <summary>
      /// When this device's subscription to email has changed
      /// </summary>
      public abstract event StateChangeDelegate<EmailSubscriptionState> EmailSubscriptionStateChanged;

      /// <summary>
      /// When this device's subscription to sms has changed
      /// </summary>
      public abstract event StateChangeDelegate<SMSSubscriptionState> SMSSubscriptionStateChanged;
      #endregion

      #region SDK Setup

      /// <summary>
      /// The minimum level of logs which will be logged to the console
      /// </summary>
      public abstract LogLevel LogLevel { get; set; }

      /// <summary>
      /// The minimum level of log events which will be converted into foreground alerts
      /// </summary>
      public abstract LogLevel AlertLevel { get; set; }

      /// <summary>
      /// Provides privacy consent. OneSignal Xamarin SDK will not initialize until this is true.
      /// </summary>
      public abstract bool PrivacyConsent { get; set; }

      /// <summary>
      /// Allows you to delay the initialization of the SDK until the user provides privacy consent. The SDK will not
      /// be fully initialized until 'PrivacyConsent = true'. Must be set before <see cref="Initialize"/> is called.
      /// </summary>
      public abstract bool RequiresPrivacyConsent { get; set; }

      /// <summary>
      /// Starts the OneSignal SDK
      /// </summary>
      /// <param name="appId">Your application id from the OneSignal dashboard</param>
      public abstract void Initialize(string appId);
      #endregion

      #region Push Notifications
      /// <summary>
      /// Prompt the user for notification permissions.
      /// </summary>
      /// <returns>Awaitable NotificationPermission which provides the user's consent status</returns>
      /// <remarks>Recommended: Do not use and instead follow
      /// <a href="https://documentation.onesignal.com/docs/ios-push-opt-in-prompt">Push Opt-In Prompt</a></remarks>
      public abstract Task<NotificationPermission> PromptForPushNotificationsWithUserResponse();

      /// <summary>
      /// Prompt the user for notification permissions.
      /// </summary>
      /// <returns>Awaitable NotificationPermission which provides the user's consent status</returns>
      /// <remarks>Recommended: Do not use and instead follow
      /// <a href="https://documentation.onesignal.com/docs/ios-push-opt-in-prompt">Push Opt-In Prompt</a></remarks>
      public abstract Task<NotificationPermission> PromptForPushNotificationsWithUserResponse(bool fallbackToSettings);

      /// <summary>
      /// Removes all OneSignal app notifications from the Notification Shade
      /// </summary>
      public abstract void ClearOneSignalNotifications();

      /// <summary>
      /// Whether push notifications are currently enabled for an active push subscription.
      /// </summary>
      /// <remarks>Can be used to turn off push notifications for a user without removing their user data</remarks>
      public abstract bool PushEnabled { get; set; }

      /// <summary>
      /// Allows you to send notifications from user to user or schedule ones in the future to be delivered to the
      /// current device.
      /// </summary>
      /// <param name="options">Contains notification options, see
      /// <a href="https://documentation.onesignal.com/reference#create-notification">Create Notification POST </a>
      /// call for all options.</param>
      /// <remarks>
      /// You can only use include_player_ids as a targeting parameter from your app. Other target options such as
      /// {@code tags} and {@code included_segments} require your OneSignal App REST API key which can only be used
      /// from your server.</remarks>
      public abstract Task<bool> PostNotification(Dictionary<string, object> options);
      #endregion

      #region In App Messages
      /// <summary>
      /// Add a local trigger. May show an In-App Message if its triggers conditions were met.
      /// </summary>
      /// <param name="key">Key for the trigger</param>
      /// <param name="value">Value for the trigger</param>
      public abstract void SetTrigger(string key, object value);

      /// <summary>
      /// Allows you to set multiple local trigger key/value pairs simultaneously. May show an In-App Message if its
      /// triggers conditions were met.
      /// </summary>
      public abstract void SetTriggers(Dictionary<string, object> triggers);

      /// <summary>
      /// Removes a single local trigger for the given key.
      /// </summary>
      /// <param name="key">Key for the trigger.</param>
      public abstract void RemoveTrigger(string key);

      /// <summary>
      /// Removes a list of local triggers based on a collection of keys.
      /// </summary>
      /// <param name="keys">Removes a collection of triggers from their keys.</param>
      public abstract void RemoveTriggers(params string[] keys);

      /// <summary>
      /// Gets a local trigger value for a provided trigger key.
      /// </summary>
      /// <param name="key">Key for the trigger.</param>
      /// <returns>Value if added with 'addTrigger', or null/nil (iOS) if never set.</returns>
      public abstract object GetTrigger(string key);

      /// <summary>
      /// Returns all local trigger key-values for the current user
      /// </summary>
      public abstract Dictionary<string, object> GetTriggers();

      /// <summary>
      /// Allows you to temporarily pause all In-App Messages. You may want to do this while the user is engaged in
      /// an activity that you don't want a message to interrupt (such as watching a video).
      /// </summary>
      public abstract bool InAppMessagesArePaused { get; set; }
      #endregion

      #region Tags
      /// <summary>
      /// Tag player with a key value pair to later create segments on them at onesignal.com
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SendTag(string key, string value);

      /// <summary>
      /// Tag player with a key value pairs to later create segments on them at onesignal.com
      /// </summary>
      /// <param name="tags"></param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SendTags(Dictionary<string, object> tags);

      /// <summary>
      /// Retrieve a list of tags that have been set on the user from the OneSignal server
      /// </summary>
      /// <returns>Awaitable <see cref="Dictionary{TKey,TValue}"/> of this user's tags</returns>
      public abstract Task<Dictionary<string, object>> GetTags();

      /// <summary>
      /// Delete a Tag from current device record
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> DeleteTag(string key);

      /// <summary>
      /// Delete multiple Tags from current device record
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> DeleteTags(params string[] keys);
      #endregion


      #region User & Device Properties
      //Required as a quick fix for iOS setExternalUser non-nullable hashToken. Need removed as soon as OneSignal iOS updates hashToken to nullable
      public abstract Task<bool> SetExternalUserId(string externalId);

      /// <summary>
      /// Allows you to use your own application's user id to send OneSignal messages to your user. To tie the user
      /// to a given user id, you can use this method.
      /// </summary>
      /// <param name="externalId">A unique id associated with the current user</param>
      /// <param name="authHash">If you have a backend server, we strongly recommend using
      /// <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification</a> with
      /// your users. Your backend can generate an email authentication token and send it to your app.</param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SetExternalUserId(string externalId, string authHash = null);

      /// <summary>
      /// Allows you to set the user's email address with the OneSignal SDK. If the user changes their email, you
      /// need to call LogoutEmail() and then SetEmail to update it.
      /// </summary>
      /// <param name="email">The email that you want subscribe and associate with the device</param>
      /// <param name="authHash">If you have a backend server, we strongly recommend using
      /// <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification</a> with
      /// your users. Your backend can generate an email authentication token and send it to your app.</param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SetEmail(string email, string authHash = null);

      /// <summary>
      /// Set an sms number for the device to later send sms to this number
      /// need to call LogoutSMS() and then SetSMSNumber to update it.
      /// </summary>
      /// <param name="smsNumber">The sms number that you want subscribe and associate with the device</param>
      /// <param name="authHash">If you have a backend server, we strongly recommend using
      /// <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification</a> with
      /// your users. Your backend can generate an email authentication token and send it to your app.</param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SetSMSNumber(string smsNumber, string authHash = null);

      ///<summary>
      ///If this user logs out of your app and/or you would like to disassociate their external user id with
      ///the device
      ///</summary>
      public abstract Task<bool> RemoveExternalUserId();

      /// <summary>
      /// If this user logs out of your app and/or you would like to disassociate their email with the current
      /// OneSignal user
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> LogoutEmail();

      /// <summary>
      /// If this user logs out of your app and/or you would like to disassociate their phone number with the
      /// current OneSignal user
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> LogoutSMS();

      ///<summary>
      ///</summary>
      public abstract DeviceState DeviceState { get; }

      /// <summary>
      /// Current status of permissions granted by this device for push notifications
      /// </summary>
      public abstract NotificationPermission NotificationPermission { get; }

      /// <summary>
      /// Current status of this device's subscription to push notifications
      /// </summary>
      public abstract PushSubscriptionState PushSubscriptionState { get; }

      /// <summary>
      /// Current status of this device's subscription to email
      /// </summary>
      public abstract EmailSubscriptionState EmailSubscriptionState { get; }

      /// <summary>
      /// Current status of this device's subscription to sms
      /// </summary>
      public abstract SMSSubscriptionState SMSSubscriptionState { get; }
      #endregion

      /// <summary>
      /// Set to true to launch all notifications with a URL in the app instead of the default web browser.
      /// iOS only method
      /// </summary>
      /// <param name="language"></param>
      public abstract void SetLaunchURLsInApp(bool launchInApp);

      /// <summary>
      /// Language is detected and set automatically through the OneSignal SDK based on the device settings.
      /// This method allows you to change that language by passing in the 2-character, lowercase 
      /// <a href="https://documentation.onesignal.com/docs/language-localization#what-languages-are-supported">ISO 639-1</a> language codes.
      /// </summary>
      /// <param name="language"></param>
      public abstract Task<bool> SetLanguage(string languageCode);

      #region Location
      /// <summary>
      /// Helper method to show the native prompt to ask the user for consent to share their location
      /// </summary>
      /// <remarks>iOS Only</remarks>
      public abstract void PromptLocation();

      /// <summary>
      /// Disable or enable location collection by OneSignal (defaults to enabled if your app has location permission).
      /// </summary>
      /// <remarks>This method must be called before <see cref="OneSignal.Initialize"/> on iOS.</remarks>
      public abstract bool ShareLocation { get; set; }
      #endregion

      #region Outcomes
      /// <summary>
      /// Send a trackable custom event which is tied to push notification campaigns
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SendOutcome(string name);

      /// <summary>
      /// Send a trackable custom event which can only happen once and is tied to push notification campaigns
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SendUniqueOutcome(string name);

      /// <summary>
      /// Send a trackable custom event with an attached value which is tied to push notification campaigns
      /// </summary>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> SendOutcomeWithValue(string name, float value);

      #endregion;


      #region Live Activities (iOS only)
      /// <summary>
      /// Register this device with OneSignal indicating that the device has entered a live activity.
      /// </summary>
      /// <param name="activityId">The (app-provided) ID of the activity that is being entered.</param>
      /// <param name="token">The (OS-provided) token that will be used to update the content-state of the live activity on this device.</param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> EnterLiveActivity(string activityId, string token);

      /// <summary>
      /// Unregister this device with OneSignal indicating that the device has exited a live activity.
      /// </summary>
      /// <param name="activityId">The (app-provided) ID of the activity that is being exited.</param>
      /// <returns>Awaitable boolean of whether the operation succeeded or failed</returns>
      public abstract Task<bool> ExitLiveActivity(string activityId);

      #endregion;
   }
}