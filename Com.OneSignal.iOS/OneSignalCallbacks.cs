using System.Collections.Generic;

using Laters;

namespace Com.OneSignal {
    public partial class OneSignalImplementation {
        private delegate void BooleanResponseDelegate(bool response);
        private delegate void StringResponseDelegate(string response);
        private delegate void DictionaryResponseDelegate(string response);

        private interface ICallbackProxy<in TReturn> {
            void OnResponse(TReturn response);
        }

        private abstract class CallbackProxy<TReturn> : BaseLater<TReturn>, ICallbackProxy<TReturn> {
            public abstract void OnResponse(TReturn response);
        }

        private sealed class BooleanCallbackProxy : CallbackProxy<bool> {
            public override void OnResponse(bool response) => _complete(response);
        }

        private sealed class StringCallbackProxy : CallbackProxy<string> {
            public override void OnResponse(string response) => _complete(response);
        }

        private sealed class DictionaryCallbackProxy : CallbackProxy<Dictionary<string, object>> {
            public override void OnResponse(Dictionary<string, object> response) => _complete(response);
        }
    }
}
