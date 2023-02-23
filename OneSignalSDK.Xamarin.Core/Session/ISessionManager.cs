using System;

namespace OneSignalSDK.Xamarin.Core.Session;

/// <summary>
/// The OneSignal session manager is responsible for managing the current session state.
/// </summary>
public interface ISessionManager
{
    /// <summary>
    /// Add an outcome with the provided name, captured against the current session.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/outcomes">Outcomes | OneSignal</a>
    /// </summary>
    /// <param name="name">The name of the outcome that has occurred.</param>
    void AddOutcome(string name);

    /// <summary>
    /// Add a unique outcome with the provided name, captured against the current session.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/outcomes">Outcomes | OneSignal</a>
    /// </summary>
    /// <param name="name">The name of the unique outcome that has occurred.</param>
    void AddUniqueOutcome(string name);

    /// <summary>
    /// Add an outcome with the provided name and value, captured against the current session.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/outcomes">Outcomes | OneSignal</a>
    /// </summary>
    /// <param name="name">The name of the outcome that has occurred.</param>
    /// <param name="value">The value tied to the outcome.</param>
    void AddOutcomeWithValue(string name, float value);
}