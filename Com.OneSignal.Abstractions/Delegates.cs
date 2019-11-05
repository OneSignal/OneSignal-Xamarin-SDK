using System;
using System.Collections.Generic;

namespace Com.OneSignal.Abstractions
{
   // NotificationReceived - Delegate is called when a push notification is received when the user is in your app.
   // notification = The Notification dictionary filled from a serialized native OSNotification object
   public delegate void NotificationReceived(OSNotification notification);

   // NotificationOpened - Delegate is called when a push notification is opened.
   // result = The Notification open result describing : 1. The notification opened 2. The action taken by the user
   public delegate void NotificationOpened(OSNotificationOpenedResult result);

   // InAppMessageClicked - Delegate is called when an IAM element is clicked
   // action = The IAM click action containing some attributes useful to the user
   public delegate void InAppMessageClicked(OSInAppMessageAction action);

   public delegate void IdsAvailableCallback(string playerID, string pushToken);
   public delegate void TagsReceived(Dictionary<string, object> tags);

   public delegate void OnPostNotificationSuccess(Dictionary<string, object> response);
   public delegate void OnPostNotificationFailure(Dictionary<string, object> response);

   public delegate void OnSetEmailSuccess();
   public delegate void OnSetEmailFailure(Dictionary<string, object> response);

   // SendOutcomeEventSuccess - Delegate is called when a SendOutcome(...), SendUniqueOutcome(...), or SendOutcomeWithValue(...) is sent successfully
   // outcomeEvent = The OutcomeEvent created in native SDK and sent along with request using measure endpoint
   public delegate void SendOutcomeEventSuccess(OSOutcomeEvent outcomeEvent);
}
