using System;
namespace Com.OneSignal.Core {
    public class EmailSubscriptionState {
        public bool isSubscribed;
        public string emailUserId;
        public string emailUserAddress;

        public EmailSubscriptionState(bool isSubscribed, string emailUserId, string emailUserAddress) {
            this.isSubscribed = isSubscribed;
            this.emailUserId = emailUserId;
            this.emailUserAddress = emailUserAddress;
        }
    }
}
