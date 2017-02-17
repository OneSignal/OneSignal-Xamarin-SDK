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

   public delegate void IdsAvailableCallback(string playerID, string pushToken);
   public delegate void TagsReceived(Dictionary<string, object> tags);

   public delegate void OnPostNotificationSuccess(Dictionary<string, object> response);
   public delegate void OnPostNotificationFailure(Dictionary<string, object> response);
}
