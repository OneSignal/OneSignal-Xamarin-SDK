using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Com.OneSignal.Core;

using OneSignalNative = Com.OneSignal.Android.OneSignal;

using Org.Json;
using Laters;

namespace Com.OneSignal {
    public partial class OneSignalImplementation {
        private class JavaLaterProxy<TResult> : Java.Lang.Object, ILater<TResult> {
            public event Action<TResult> OnComplete {
                add => _later.OnComplete += value;
                remove => _later.OnComplete -= value;
            }

            public TaskAwaiter<TResult> GetAwaiter() {
                return _later.GetAwaiter();
            }

            protected Later<TResult> _later = new Later<TResult>();
        }

        private sealed class OSSMSUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IOSSMSUpdateHandler {
            public void OnSuccess(JSONObject jsonResults) {
                _later.Complete(true);
            }

            public void OnFailure(OneSignalNative.OSSMSUpdateError error) {
                _later.Complete(false);
            }
        }

        private sealed class OSEmailUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IEmailUpdateHandler {
            public void OnSuccess() {
                _later.Complete(true);
            }

            public void OnFailure(OneSignalNative.EmailUpdateError error) {
                _later.Complete(false);
            }
        }

        private sealed class OSGetTagsHandler : JavaLaterProxy<Dictionary<string, object>>, OneSignalNative.IOSGetTagsHandler {
            public void TagsAvailable(JSONObject tags) {
                var result = Json.Deserialize(tags.ToString()) as Dictionary<string, object>;
                _later.Complete(result);
            }
        }

        private sealed class OSExternalUserIDUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IOSExternalUserIdUpdateCompletionHandler {
            public void OnSuccess(JSONObject jsonResults) {
                _later.Complete(true);
            }

            public void OnFailure(OneSignalNative.ExternalIdError error) {
                _later.Complete(false);
            }
        }

        private sealed class OSChangeTagsUpdateHandler : JavaLaterProxy<bool>, OneSignalNative.IChangeTagsUpdateHandler {
            public void OnSuccess(JSONObject jsonResults) {
                _later.Complete(true);
            }

            public void OnFailure(OneSignalNative.SendTagsError error) {
                _later.Complete(false);
            }
        }

        private sealed class OSOutcomeCallback : JavaLaterProxy<bool>, OneSignalNative.IOutcomeCallback {
            public void OnSuccess(Com.OneSignal.Android.OSOutcomeEvent outcome) {
                _later.Complete(true);
            }

            public void OnFailure(OneSignalNative.SendTagsError error) {
                _later.Complete(false);
            }
        }


        private sealed class OSPostNotificationResponseHandler : JavaLaterProxy<bool>, OneSignalNative.IPostNotificationResponseHandler {
            public void OnSuccess(JSONObject jsonResults) {
                _later.Complete(true);
            }

            public void OnFailure(JSONObject error) {
                _later.Complete(false);
            }
        }
    }
}
