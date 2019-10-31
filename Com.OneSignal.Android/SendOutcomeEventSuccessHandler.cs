using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Com.OneSignal.Android;

namespace Com.OneSignal
{
   public class SendOutcomeEventSuccessHandler : Java.Lang.Object, Android.OneSignal.IOutcomeCallback
   {
    
      readonly SendOutcomeEventSuccess _sendOutcomeEventSuccess;

	   public SendOutcomeEventSuccessHandler(SendOutcomeEventSuccess sendOutcomeEventSuccess) => _sendOutcomeEventSuccess = sendOutcomeEventSuccess;

      public void OnSuccess(OutcomeEvent outcome)
      {
         OSOutcomeEvent outcomeEvent = OSSendOutcomeEventSuccessToNative(outcome);
         _sendOutcomeEventSuccess(outcomeEvent);
      }

      private static OSOutcomeEvent OSSendOutcomeEventSuccessToNative(OutcomeEvent outcome)
      {
         if (outcome == null)
            return new OSOutcomeEvent();

         Dictionary<string, object> outcomeObject = Json.Deserialize(outcome.ToJSONObject().ToString()) as Dictionary<string, object>;

         OSOutcomeEvent outcomeEvent = new OSOutcomeEvent();
        
         // session
         if (outcomeObject.ContainsKey("session"))
            outcomeEvent.session = OSOutcomeEvent.SessionFromString(outcomeObject["session"] as string);

         // notificationIds
         if (outcomeObject.ContainsKey("notification_ids")) {
            List<object> idObjects = outcomeObject["notification_ids"] as List<object>;
            List<string> ids = new List<string>();
            foreach (var id in idObjects)
                  ids.Add(id.ToString());

            outcomeEvent.notificationIds = ids;
         }

         // id
         if (outcomeObject.ContainsKey("id"))
            outcomeEvent.name = outcomeObject["id"] as string;

         // timestamp
         if (outcomeObject.ContainsKey("timestamp"))
            outcomeEvent.timestamp = (long) outcomeObject["timestamp"];

         // weight
         if (outcomeObject.ContainsKey("weight")) {
            if (outcomeObject["weight"] is Int64)
                  outcomeEvent.weight = (Int64) outcomeObject["weight"];
            if (outcomeObject["weight"] is Double)
                  outcomeEvent.weight = (Double) outcomeObject["weight"];
         }

         return outcomeEvent;
      }
   }
}
