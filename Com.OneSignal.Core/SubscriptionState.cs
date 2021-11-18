using System;
namespace Com.OneSignal.Core {
    public class SubscriptionState {
        public bool isPushDisabled;
        public string userId;
        public string pushToken;
        public bool subscribed;

        public SubscriptionState(bool isPushDisabled, string userId, string pushToken, bool subscribed) {
            this.isPushDisabled = isPushDisabled;
            this.userId = userId;
            this.pushToken = pushToken;
            this.subscribed = subscribed;
        }
    }
}
