using System;
namespace Com.OneSignal.Core {
    public class SMSSubscriptionState {
        public bool isSubscribed;
        public string smsUserId;
        public string smsNumber;

        public SMSSubscriptionState(bool isSubscribed, string smsUserId, string smsNumber) {
            this.isSubscribed = isSubscribed;
            this.smsUserId = smsUserId;
            this.smsNumber = smsNumber;
        }
    }
}
