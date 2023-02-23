using System;

namespace OneSignalSDK.Xamarin.Core.InAppMessages;

/// <summary>
/// The <see cref="EventArgs"/> for an In App Message lifecycle event:
/// * <see cref="IInAppMessagesManager.WillDisplay"/>
/// * <see cref="IInAppMessagesManager.DidDisplay"/>
/// * <see cref="IInAppMessagesManager.WillDismiss"/>
/// * <see cref="IInAppMessagesManager.DidDismiss"/>
/// </summary>
public sealed class InAppMessageLifecycleEventArgs : EventArgs
{
    /// <summary>
    /// The message that has raised the lifecycle event.
    /// </summary>
    public InAppMessage Message { get; }

    public InAppMessageLifecycleEventArgs(InAppMessage message)
    {
        Message = message;
    }
}
