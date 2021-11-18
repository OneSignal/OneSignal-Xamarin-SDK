using System;
using System.Collections.Generic;

//using Org.Json;

namespace Com.OneSignal.Core {

   public delegate void InAppMessageClicked(InAppMessageAction action);

   public delegate void OnSetSMSSuccess(Dictionary<string, object> results);
   public delegate void OnSetSMSFailure(Dictionary<string, object> response);

   public delegate void OnSetEmailSuccess();
   public delegate void OnSetEmailFailure(Dictionary<string, object> results);

   public delegate void OnExternalUserIdUpdateSuccess(Dictionary<string, object> results);
   public delegate void OnExternalUserIdUpdateFailure(Dictionary<string, object> response);

   //public delegate void OnTagsReceivedSuccess(JSONObject results);
   public delegate void OnTagsReceivedFailure(Dictionary<string, object> response);

   public delegate void TagsReceived(Dictionary<string, object> tags);

   public delegate void OnPostNotificationSuccess(Dictionary<string, object> results);
   public delegate void OnPostNotificationFailure(Dictionary<string, object> response);

   public delegate void SendOutcomeEventSuccess(OutcomeEvent outcomeEvent);
}