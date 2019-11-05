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

         OSOutcomeEvent outcomeEvent = new OSOutcomeEvent(outcomeObject);

         return outcomeEvent;
      }
   }
}
