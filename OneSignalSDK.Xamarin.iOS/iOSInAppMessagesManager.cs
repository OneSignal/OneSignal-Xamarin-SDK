using System;
using System.Collections.Generic;
using Foundation;
using OneSignalSDK.Xamarin.Core;
using OneSignalSDK.Xamarin.Core.InAppMessages;
using OneSignalSDK.Xamarin.iOS.Utilities;
using OneSignalNative = Com.OneSignal.iOS.OneSignal;

namespace OneSignalSDK.Xamarin.iOS;

public class iOSInAppMessagesManager : Core.InAppMessages.IInAppMessagesManager
{
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDisplay;
    public event EventHandler<InAppMessageLifecycleEventArgs>? WillDismiss;
    public event EventHandler<InAppMessageLifecycleEventArgs>? DidDismiss;
    public event EventHandler<InAppMessageClickedEventArgs>? Clicked;

    public bool Paused
    {
        get => OneSignalNative.InAppMessages.IsPaused;
        set => OneSignalNative.InAppMessages.SetPaused(value);
    }

    private InternalInAppMessageLifeCycleHandler? _lifecycleHandler;

    public void Initialize()
    {
        _lifecycleHandler = new InternalInAppMessageLifeCycleHandler(this);
        OneSignalNative.InAppMessages.SetLifecycleHandler(_lifecycleHandler);
        OneSignalNative.InAppMessages.SetClickHandler(OnClick);
    }

    public void AddTrigger(string key, object value) => OneSignalNative.InAppMessages.AddTrigger(key, NSObject.FromObject(value));
    public void AddTriggers(IDictionary<string, object> triggers) => OneSignalNative.InAppMessages.AddTriggers(NativeConversion.DictToNSDict(triggers));
    public void ClearTriggers() => OneSignalNative.InAppMessages.ClearTriggers();
    public void RemoveTrigger(string key) => OneSignalNative.InAppMessages.RemoveTrigger(key);
    public void RemoveTriggers(params string[] keys) => OneSignalNative.InAppMessages.RemoveTriggers(keys);

    private void OnClick(Com.OneSignal.iOS.OSInAppMessageAction action)
    {
        var args = new InAppMessageClickedEventArgs(FromNativeConversion.ToInAppMessageAction(action));
        Clicked?.Invoke(this, args);
    }

    private sealed class InternalInAppMessageLifeCycleHandler : Com.OneSignal.iOS.OSInAppMessageLifecycleHandler
    {
        private iOSInAppMessagesManager _manager;
        public InternalInAppMessageLifeCycleHandler(iOSInAppMessagesManager manager) : base()
        {
            _manager = manager;
        }

        public override void OnDidDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.DidDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnDidDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.DidDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnWillDismissInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.WillDismiss?.Invoke(_manager, GetLifecycleArgs(message));
        }

        public override void OnWillDisplayInAppMessage(Com.OneSignal.iOS.OSInAppMessage message)
        {
            _manager.WillDisplay?.Invoke(_manager, GetLifecycleArgs(message));
        }

        private InAppMessageLifecycleEventArgs GetLifecycleArgs(Com.OneSignal.iOS.OSInAppMessage message)
        {
            return new InAppMessageLifecycleEventArgs(FromNativeConversion.ToInAppMessage(message));
        }
    }
}
