using System;

namespace OneSignalSDK.Xamarin.Core.User.Subscriptions; 

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="ISubscription.Changed"/> event.
/// </summary>
public sealed class SubscriptionChangedEventArgs : EventArgs
{
    /// <summary>
    /// The subscription that has changed, in its new state.
    /// </summary>
    public ISubscription Subscription { get; }

    public SubscriptionChangedEventArgs(ISubscription subscription)
    {
        Subscription = subscription;
    }
}
