using System.Collections.Generic;
using Com.OneSignal.Abstractions;
using Org.Json;

namespace Com.OneSignal
{
   public class OSExternalUserIdUpdateCompletionHandler : Java.Lang.Object
	{
		readonly OnExternalUserIdUpdate _completion;

		public OSExternalUserIdUpdateCompletionHandler(OnExternalUserIdUpdate completion)
		{
			_completion = completion;
		}

      public void OnComplete(JSONObject jsonResults)
      {
         if (_completion == null)
               return;

         Dictionary<string, object> results = new Dictionary<string, object>();
         if (jsonResults != null)
            results = Json.Deserialize(jsonResults.ToString()) as Dictionary<string, object>;
         _completion?.Invoke(results);
      }
	}
}
