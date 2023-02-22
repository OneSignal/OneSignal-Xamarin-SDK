using System;

namespace OneSignalSDK.Xamarin.Core.User.Subscriptions;

/// <summary>
/// A subscription.
/// </summary>
public interface ISubscription
{
    /// <summary>
    /// Event for when the subscription has changed.
    /// </summary>
    event EventHandler<SubscriptionChangedEventArgs> Changed;

    /// <summary>
    /// The unique identifier for this subscription. This will be an empty string
    /// until the subscription has been successfully created on the backend and
    /// assigned an ID. Use <see cref="Changed"/> to be notified when the
    /// <see cref="Id"/> has been successfully assigned.
    /// </summary>
    string Id { get; }
}