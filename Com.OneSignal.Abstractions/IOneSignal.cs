using System;
using System.Collections.Generic;

namespace Com.OneSignal.Abstractions
{
   public interface IOneSignal
   {
      XamarinBuilder StartInit(string appID);

      void SetLogLevel(LOG_LEVEL logLevel, LOG_LEVEL visualLevel);
      void RegisterForPushNotifications();
      void SendTag(string tagName, string tagValue);
      void SendTags(IDictionary<string, string> tags);
      void GetTags(TagsReceived tagsReceivedDelegate);
      void DeleteTag(string key);
      void DeleteTags(IList<string> keys);
      void IdsAvailable(IdsAvailableCallback idsAvailableCallback);
      void SetSubscription(bool enable);
      void PostNotification(Dictionary<string, object> data, OnPostNotificationSuccess success, OnPostNotificationFailure failure);
      void PostNotification(Dictionary<string, object> data);

      [Obsolete("SyncHashedEmail has been deprecated. Please use setEmail() instead.")]
      void SyncHashedEmail(string email);
      void PromptLocation();
      void SetEmail(string email, string emailAuthToken, OnSetEmailSuccess success, OnSetEmailFailure failure);
      void SetEmail(string email, string emailAuthToken);
      void SetEmail(string email, OnSetEmailSuccess success, OnSetEmailFailure failure);
      void SetEmail(string email);
      void LogoutEmail(OnSetEmailSuccess success, OnSetEmailFailure failure);
      void LogoutEmail();
      void ClearAndroidOneSignalNotifications();
      void SetLocationShared(bool shared);

      void UserDidProvidePrivacyConsent(bool granted);
      bool RequiresUserPrivacyConsent();
      void SetRequiresUserPrivacyConsent(bool required);
   }
}
 