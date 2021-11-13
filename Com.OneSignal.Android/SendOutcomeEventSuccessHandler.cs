using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Com.OneSignal.Android;

namespace Com.OneSignal
{
   public class SendOutcomeEventSuccessHandler : Java.Lang.Object
   {
    
      readonly SendOutcomeEventSuccess _sendOutcomeEventSuccess;

	   public SendOutcomeEventSuccessHandler(SendOutcomeEventSuccess sendOutcomeEventSuccess) => _sendOutcomeEventSuccess = sendOutcomeEventSuccess;
   }
}
