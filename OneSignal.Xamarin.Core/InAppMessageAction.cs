using System;
using System.Collections.Generic;

namespace OneSignal.Xamarin.Core {
   [Serializable]
   public sealed class InAppMessageAction {
      public string click_name;
      public string click_url;
      public bool first_click;
      public bool closes_message;
   }
}
