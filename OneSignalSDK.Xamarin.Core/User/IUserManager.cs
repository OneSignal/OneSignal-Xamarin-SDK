using System;
using System.Collections.Generic;
using OneSignalSDK.Xamarin.Core.User.Subscriptions;

namespace OneSignalSDK.Xamarin.Core.User;

/// <summary>
/// The OneSignal user manager is responsible for managing the current user state.  When
/// an app starts up for the first time, it is defaulted to having a guest user that is only
/// accessible by the current device.Once the application knows the identity of the user using their
/// app, they should call[OneSignal.login] providing that identity to OneSignal, at which
/// point all state in here will reflect the state of that known user.
///
/// The current user is persisted across the application lifecycle, even when the application
/// is restarted.It is up to the application developer to call <see cref="IOneSignal.Login(string, string?)"/> when
/// the user of the application switches, or logs out, to ensure the identity tracked by OneSignal
/// remains in sync.
///
/// When you should call <see cref="IOneSignal.Login(string, string?)"/>:
/// <list type="number">
/// <item><description>When the identity of the user changes(i.e.a login or a context switch)</description></item>
/// <item><description>When the identity of the user is lost(i.e.a logout)</description></item>
/// </list>
/// </summary>
public interface IUserManager
{
    /// <summary>
    /// The 2-character language either as a detected language or explicitly set for this user. See
    /// <a href="https://documentation.onesignal.com/docs/language-localization#what-languages-are-supported">Supported Languages | OneSignal</a>
    /// </summary>
    string Language { set; }

    /// <summary>
    /// The push subscription associated to the current user.
    /// </summary>
    IPushSubscription PushSubscription { get; }

    /// <summary>
    /// Set an alias for the current user.  If this alias already exists it will be overwritten.
    /// </summary>
    /// <param name="label">The alias label that you want to set against the current user.</param>
    /// <param name="id">
    /// The alias id that should be set against the current user. This must be a unique value
    /// within the alias label across your entire user base so it can uniquely identify this user.
    /// </param>
    void AddAlias(string label, string id);

    /// <summary>
    /// Add/set aliases for the current user. If any alias already exists it will be overwritten.
    /// </summary>
    /// <param name="aliases">
    /// A map of the alias label -> alias id that should be set against the user. Each
    /// alias id must be a unique value within the alias label across your entire user base so it can
    /// uniquely identify this user.
    /// </param>
    void AddAliases(IDictionary<string, string> aliases);

    /// <summary>
    /// Remove an alias from the current user.
    /// </summary>
    /// <param name="label">The alias label that should no longer be set for the current user.</param>
    void RemoveAlias(string label);

    /// <summary>
    /// Remove multiple aliases from the current user.
    /// </summary>
    /// <param name="labels">The collection of alias labels, all of which will be removed from the current user.</param>
    void RemoveAliases(params string[] labels);

    /// <summary>
    /// Add a new email subscription to the current user.
    /// </summary>
    /// <param name="email">The email address that the current user has subscribed for.</param>
    void AddEmail(string email);

    /// <summary>
    /// Remove an email subscription from the current user.
    /// </summary>
    /// <param name="email">The email address that the current user was subscribed for, and should no longer be.</param>
    void RemoveEmail(string email);

    /// <summary>
    /// Add a new SMS subscription to the current user.
    /// </summary>
    /// <param name="sms">
    /// The phone number that the current user has subscribed for, in
    /// <a href="https://documentation.onesignal.com/docs/sms-faq#what-is-the-e164-format">E.164</a>format.
    /// </param>
    void AddSms(string sms);

    /// <summary>
    /// Remove an SMS subscription from the current user.
    /// </summary>
    /// <param name="sms">The sms address that the current user was subscribed for, and should no longer be.</param>
    void RemoveSms(string sms);

    /// <summary>
    /// Add a tag for the current user.  Tags are key:value pairs used as building blocks
    /// for targeting specific users and/or personalizing messages. If the tag key already exists, it will be replaced
    /// with the value provided here.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/add-user-data-tags">Data Tags | OneSignal</a>.
    /// </summary>
    /// <param name="key">The key of the data tag.</param>
    /// <param name="value">The new value of the data tag.</param>
    void AddTag(string key, string value);

    /// <summary>
    /// Add multiple tags for the current user.  Tags are key:value pairs used as building blocks
    /// for targeting specific users and/or personalizing messages. If the tag key already exists, it will be replaced
    /// with the value provided here.
    ///
    /// See <a href="https://documentation.onesignal.com/docs/add-user-data-tags">Data Tags | OneSignal</a>.
    /// </summary>
    /// <param name="tags">A map of tags, all of which will be added/updated for the current user.</param>
    void AddTags(IDictionary<string, string> tags);

    /// <summary>
    /// Remove the data tag with the provided key from the current user.
    /// </summary>
    /// <param name="key">The key of the data tag.</param>
    void RemoveTag(string key);

    /// <summary>
    /// Remove multiple tags from the current user.
    /// </summary>
    /// <param name="keys">The collection of keys, all of which will be removed from the current user.</param>
    void RemoveTags(params string[] keys);
}