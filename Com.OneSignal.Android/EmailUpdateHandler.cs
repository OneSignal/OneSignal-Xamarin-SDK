using System;
using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Org.Json;

namespace Com.OneSignal
{
  public class EmailUpdateHandler : Java.Lang.Object
  {
    public void OnSuccess() 
    {
      (OneSignal.Current as OneSignalImplementation).onSetEmailSuccess();
    }

    public void OnFailure(JSONObject jsonObject) 
    {
      Dictionary<string, object> dict = null;

      (OneSignal.Current as OneSignalImplementation).onSetEmailFailed(dict);
    }
  }
}
