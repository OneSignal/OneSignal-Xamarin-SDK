using System;
using System.Collections.Generic;

namespace OneSignalSDK.Xamarin.Core {
   [Serializable]
   public sealed class InAppMessageAction {
      /// <summary>
      /// An optional click name defined for the action element
      /// </summary>
      public string clickName;

      /// <summary>
      /// An optional URL that opens when the action takes place
      /// </summary>
      public string clickUrl;

      /// <summary>
      /// Whether this is the first time the user has clicked any action on the In-App Message
      /// </summary>
      public bool firstClick;

      /// <summary>
      /// Whether this action will close the In-App Message
      /// </summary>
      public bool closesMessage;
   }
}
