using System;
using System.Collections.Generic;

namespace Com.OneSignal.Core {
   public class InAppMessageActionUrlType {
      //Potentially Unnecessary declarations
      public static readonly InAppMessageActionUrlType IN_APP_WEBVIEW = new InAppMessageActionUrlType("webview");
      public static readonly InAppMessageActionUrlType BROWSER = new InAppMessageActionUrlType("browser");
      public static readonly InAppMessageActionUrlType REPLACE_CONTENT = new InAppMessageActionUrlType("replacement");

      public static IEnumerable<InAppMessageActionUrlType> inAppMessageActionUrlTypes {
         get {
            yield return IN_APP_WEBVIEW;
            yield return BROWSER;
            yield return REPLACE_CONTENT;
         }
      }

      public string inAppMessageActionUrlType { get; private set; }

      public InAppMessageActionUrlType(string inAppMessageActionUrlType) =>
         (this.inAppMessageActionUrlType) = (inAppMessageActionUrlType);
   }
}
