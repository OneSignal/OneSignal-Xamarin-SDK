using System;
using System.Collections.Generic;

namespace Com.OneSignal.Core {

   public class InAppMessageAction {
      public string clickName;
      public InAppMessageActionUrlType urlTarget;
      public string clickUrl;
      public IList<InAppMessageOutcome> outcomes;
      public IList<InAppMessagePrompt> prompts;
      public InAppMessageTag tags;
      public bool isFirstClick;
      public bool doesCloseMessage;
   }
}
