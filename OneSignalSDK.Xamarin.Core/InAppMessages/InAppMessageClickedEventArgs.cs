using System;

namespace OneSignalSDK.Xamarin.Core.InAppMessages;

/// <summary>
/// The <see cref="EventArgs"/> for the <see cref="IInAppMessagesManager.Clicked"/> event.
/// </summary>
public sealed class InAppMessageClickedEventArgs : EventArgs
{
    /// <summary>
    /// The action that was taken due to the click.
    /// </summary>
    public InAppMessageAction Action { get; }

    public InAppMessageClickedEventArgs(InAppMessageAction action)
    {
        Action = action;
    }
}
