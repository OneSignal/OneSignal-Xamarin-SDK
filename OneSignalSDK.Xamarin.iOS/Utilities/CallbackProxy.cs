using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using OneSignalSDK.Xamarin.Core.Internal.Utilities;

namespace OneSignalSDK.Xamarin.iOS.Utilities;

/// <summary>
/// The abstract class that is to be used to bridge objective-c / swift callbacks
/// to .NET's async pattern.  The appropriate implementing class should be used,
/// depending on what the objective-c / swift function calls back with.
/// </summary>
/// <typeparam name="TResult">The expected .NET return type of the method being called.</typeparam>
public abstract class CallbackProxy<TReturn>
{
    protected TaskCompletionSource<TReturn> _completionSource = new TaskCompletionSource<TReturn>();

    public TaskAwaiter<TReturn> GetAwaiter()
    {
        return _completionSource.Task.GetAwaiter();
    }

    public void OnResponse(TReturn response)
    {
        _completionSource.TrySetResult(response);
    }
}

/// <summary>
/// A boolean callback proxy.
/// </summary>
public sealed class BooleanCallbackProxy : CallbackProxy<bool>
{
}
