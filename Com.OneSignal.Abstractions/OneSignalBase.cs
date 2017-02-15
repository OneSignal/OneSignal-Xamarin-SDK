using System;
using System.Collections.Generic;

namespace Com.OneSignal.Abstractions
{
    public abstract class OneSignalBase
    {
        // NotificationReceived - Delegate is called when a push notification is received when the user is in your game.
        // notification = The Notification dictionary filled from a serialized native OSNotification object
        public delegate void NotificationReceived(OSNotification notification);

        // NotificationOpened - Delegate is called when a push notification is opened.
        // result = The Notification open result describing : 1. The notification opened 2. The action taken by the user
        public delegate void NotificationOpened(OSNotificationOpenedResult result);

        public delegate void IdsAvailableCallback(string playerID, string pushToken);
        public delegate void TagsReceived(Dictionary<string, object> tags);

        public delegate void OnPostNotificationSuccess(Dictionary<string, object> response);
        public delegate void OnPostNotificationFailure(Dictionary<string, object> response);

        // delegates
        IdsAvailableCallback idsAvailableDelegate;
        public TagsReceived tagsReceivedDelegate;

        public const string kOSSettingsKeyAutoPrompt = "kOSSettingsKeyAutoPrompt";
        public const string kOSSettingsKeyInAppLaunchURL = "kOSSettingsKeyInAppLaunchURL";

        // logging
        public LOG_LEVEL logLevel = LOG_LEVEL.INFO, visualLogLevel = LOG_LEVEL.NONE;

        internal OnPostNotificationSuccess postNotificationSuccessDelegate;
        internal OnPostNotificationFailure postNotificationFailureDelegate;

        // Name of the GameObject that gets automaticly created in your game scene.
        private const string gameObjectName = "OneSignalRuntimeObject_KEEP";

        public XamarinBuilder builder;

        // Init - Only required method you call to setup OneSignal to recieve push notifications.
        //        Call this on the first scene that is loaded.
        // appId                            = Your OneSignal AppId from onesignal.com

        public XamarinBuilder Init(string appID, string googleProjectNumber = "")
        {
            if (builder == null)
                builder = new XamarinBuilder();

            builder.appID = appID;
            builder.googleProjectNumber = googleProjectNumber;

            //Init here instead of in builder
            InitPlatform();

            return builder;
        }

        // Init - Only required method you call to setup OneSignal to receive push notifications.
        public abstract void InitPlatform();

        public abstract void GetTags();

        // Makes a request to onesignal.com to get current tags set on the player and then run the callback passed in.
        public void GetTags(TagsReceived inTagsReceivedDelegate)
        {
            tagsReceivedDelegate = inTagsReceivedDelegate;
            GetTags();
        }

        public abstract void IdsAvailable();

        public void IdsAvailable(IdsAvailableCallback inIdsAvailableDelegate)
        {
            idsAvailableDelegate = inIdsAvailableDelegate;
            IdsAvailable();
        }

        public virtual void SetLogLevel(LOG_LEVEL ll, LOG_LEVEL vll)
        {
                logLevel = ll;
                visualLogLevel = vll;
        }

        public abstract void PostNotification(Dictionary<string, object> data);

        public void PostNotification(Dictionary<string, object> data, OnPostNotificationSuccess inOnPostNotificationSuccess, OnPostNotificationFailure inOnPostNotificationFailure)
        {
            postNotificationSuccessDelegate = inOnPostNotificationSuccess;
            postNotificationFailureDelegate = inOnPostNotificationFailure;

            PostNotification(data);
        }

        // Called from the native SDK - Called when a push notification received.
      public void onPushNotificationReceived(OSNotification notification) {
            if (builder._notificationReceivedDelegate != null)
            {
               builder._notificationReceivedDelegate(notification);
            }
        }

          // Called from the native SDK - Called when a push notification is opened by the user
      public void onPushNotificationOpened(OSNotificationOpenedResult result) {
          if (builder._notificationOpenedDelegate != null) {
             builder._notificationOpenedDelegate(result);
          }
       }
          
       // Called from the native SDK - Called when device is registered with onesignal.com service or right after IdsAvailable
       //                          if already registered.
       public void onIdsAvailable(string userId, string pushToken) {
          if (idsAvailableDelegate != null) {
            idsAvailableDelegate(userId, pushToken);
          }
       }

       // Called from the native SDK - Called After calling GetTags(...)
       public void onTagsReceived(Dictionary<string, object> dict) {
          if (tagsReceivedDelegate != null)
             tagsReceivedDelegate(dict);
       }

       // Called from the native SDK
      public void onPostNotificationSuccess(Dictionary<string, object> response) {
          if (postNotificationSuccessDelegate != null) {
             OnPostNotificationSuccess tempPostNotificationSuccessDelegate = postNotificationSuccessDelegate;
             postNotificationFailureDelegate = null;
             postNotificationSuccessDelegate = null;
             tempPostNotificationSuccessDelegate(response);
          }
       }

       // Called from the native SDK
       public void onPostNotificationFailed(Dictionary<string, object> response) {
          if (postNotificationFailureDelegate != null) {
             OnPostNotificationFailure tempPostNotificationFailureDelegate = postNotificationFailureDelegate;
             postNotificationFailureDelegate = null;
             postNotificationSuccessDelegate = null;
             tempPostNotificationFailureDelegate(response);
          }
       }
    }
}
