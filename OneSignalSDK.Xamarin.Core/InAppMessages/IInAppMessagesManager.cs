using System;
using System.Collections.Generic;

namespace OneSignalSDK.Xamarin.Core.InAppMessages;

/// <summary>
/// The In App Message (IAM) Manager is a *device-scoped* manager for controlling the IAM
/// functionality within your application.By default IAMs are enabled and will present
/// if the current user qualifies for any IAMs sent down by the OneSignal backend.To
/// blanket disable IAMs, set <see cref="Paused"/> to <code>true</code> on startup.
/// </summary>
public interface IInAppMessagesManager
{
    /// <summary>
    /// Event for when an In App Message is about to be displayed to the screen.
    /// </summary>
    event EventHandler<InAppMessageLifecycleEventArgs> WillDisplay;

    /// <summary>
    /// Event for when an In App Message is has been displayed to the screen.
    /// </summary>
    event EventHandler<InAppMessageLifecycleEventArgs> DidDisplay;

    /// <summary>
    /// Event for when a user has chosen to dismiss an In App Message.
    /// </summary>
    event EventHandler<InAppMessageLifecycleEventArgs> WillDismiss;

    /// <summary>
    /// Event for when an In App Message has finished being dismissed.
    /// </summary>
    event EventHandler<InAppMessageLifecycleEventArgs> DidDismiss;

    /// <summary>
    /// Event for when a user has clicked on an In App Message.
    /// </summary>
    event EventHandler<InAppMessageClickedEventArgs> Clicked;

    /// <summary>
    /// Whether the In App Messaging is currently paused.  When set to <code>true</code> no IAM
    /// will be presented to the user regardless of whether they qualify for them. When
    /// set to <code>false</code> any IAMs the user qualifies for will be presented to the user
    /// at the appropriate time.
    /// </summary>
    bool Paused { get; set; }

    /// <summary>
    /// Add a trigger for the current user.  Triggers are currently explicitly used to determine
    /// whether a specific IAM should be displayed to the user.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/iam-triggers">Triggers | OneSignal</a>.
    ///
    /// If the trigger key already exists, it will be replaced with the value provided here.Note that
    /// triggers are not persisted to the backend.They only exist on the local device and are applicable
    /// to the current user.
    /// </summary>
    /// <param name="key">The key of the trigger that is to be set.</param>
    /// <param name="value">The value of the trigger.</param>
    void AddTrigger(string key, object value);

    /// <summary>
    /// Add multiple triggers for the current user.  Triggers are currently explicitly used to determine
    /// whether a specific IAM should be displayed to the user.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/iam-triggers">Triggers | OneSignal</a>.
    ///
    /// If the trigger key already exists, it will be replaced with the value provided here.Note that
    /// triggers are not persisted to the backend.They only exist on the local device and are applicable
    /// to the current user.
    /// </summary>
    /// <param name="triggers">The map of triggers that are to be added to the current user.</param>
    void AddTriggers(IDictionary<string, object> triggers);

    /// <summary>
    /// Remove the trigger with the provided key from the current user.
    /// </summary>
    /// <param name="key">The key of the trigger.</param>
    void RemoveTrigger(string key);

    /// <summary>
    /// Remove multiple triggers from the current user.
    /// </summary>
    /// <param name="keys">The collection of keys, all of which will be removed from the current user.</param>
    void RemoveTriggers(params string[] keys);

    /// <summary>
    /// Clear all triggers from the current user.
    /// </summary>
    void ClearTriggers();
}