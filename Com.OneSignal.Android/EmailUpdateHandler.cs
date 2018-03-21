using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Org.Json;

namespace Com.OneSignal
{
  public class EmailUpdateHandler : Java.Lang.Object, Android.OneSignal.IEmailUpdateHandler
  {
    public void OnSuccess()
    {
      (OneSignal.Current as OneSignalImplementation).onSetEmailSuccess();
    }

    public void OnFailure(Android.OneSignal.EmailUpdateError error)
    {
      var result = new Dictionary<string, object> () {{"message", error.Message}};

      (OneSignal.Current as OneSignalImplementation).onPostNotificationFailed(result);
    }
  }
}
