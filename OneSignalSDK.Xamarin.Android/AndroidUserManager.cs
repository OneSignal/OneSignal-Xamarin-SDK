using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.User;
using OneSignalSDK.Xamarin.Core.User.Subscriptions;
using OneSignalNative = Com.OneSignal.Android.OneSignal;

namespace OneSignalSDK.Xamarin.Android
{
    public class AndroidUserManager : IUserManager
    {
        public string Language
        {
            set => OneSignalNative.User.SetLanguage(value);
        }

        public IPushSubscription PushSubscription { get; } = new AndroidPushSubscription();

        public void Initialize()
        {
            ((AndroidPushSubscription)PushSubscription).Initialize();
        }

        public void AddAlias(string label, string id) => OneSignalNative.User.AddAlias(label, id);
        public void AddAliases(IDictionary<string, string> aliases) => OneSignalNative.User.AddAliases(aliases);
        public void RemoveAlias(string label) => OneSignalNative.User.RemoveAlias(label);
        public void RemoveAliases(params string[] labels) => OneSignalNative.User.RemoveAliases(labels);

        public void AddEmail(string email) => OneSignalNative.User.AddEmail(email);
        public void RemoveEmail(string email) => OneSignalNative.User.RemoveEmail(email);

        public void AddSms(string sms) => OneSignalNative.User.AddSms(sms);
        public void RemoveSms(string sms) => OneSignalNative.User.RemoveSms(sms);

        public void AddTag(string key, string value) => OneSignalNative.User.AddTag(key, value);
        public void AddTags(IDictionary<string, string> tags) => OneSignalNative.User.AddTags(tags);
        public void RemoveTag(string key) => OneSignalNative.User.RemoveTag(key);
        public void RemoveTags(params string[] keys) => OneSignalNative.User.RemoveTags(keys);
    }

    public class AndroidPushSubscription : IPushSubscription
    {
        public string Token => OneSignalNative.User.PushSubscription.Token;

        public bool OptedIn => OneSignalNative.User.PushSubscription.OptedIn;

        public string Id => OneSignalNative.User.PushSubscription.Id;

        public event EventHandler<SubscriptionChangedEventArgs>? Changed;

        private InternalSubscriptionChangedHandler? _subscriptionChangedHandler;

        public void Initialize()
        {
            _subscriptionChangedHandler = new InternalSubscriptionChangedHandler(this);
            OneSignalNative.User.PushSubscription.AddChangeHandler(_subscriptionChangedHandler);
        }

        public void OptIn()
        {
            OneSignalNative.User.PushSubscription.OptIn();
        }

        public void OptOut()
        {
            OneSignalNative.User.PushSubscription.OptOut();
        }

        private class InternalSubscriptionChangedHandler : Java.Lang.Object, Com.OneSignal.Android.User.Subscriptions.ISubscriptionChangedHandler
        {
            private AndroidPushSubscription _manager;
            public InternalSubscriptionChangedHandler(AndroidPushSubscription manager)
            {
                _manager = manager;
            }

            public void OnSubscriptionChanged(Com.OneSignal.Android.User.Subscriptions.ISubscription subscription)
            {
                _manager.Changed?.Invoke(_manager, new SubscriptionChangedEventArgs(_manager));
            }
        }
    }
}
