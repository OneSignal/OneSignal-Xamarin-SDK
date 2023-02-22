using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Com.OneSignal.Android;
using Java.Util.Functions;

namespace OneSignalSDK.Xamarin.Android;

/// <summary>
/// The abstract <see cref="IConsumer"/> that is to be used to bridge Kotlin
/// suspending functions to .NET's async pattern.  The appropriate implementing
/// class should be used, depending on what the Kotlin function returns, and
/// should be passed into <see cref="Continue.With(IConsumer)"/> method.
/// </summary>
/// <typeparam name="TResult">The expected .NET return type of the method being called.</typeparam>
public abstract class AndroidConsumer<TResult> : Java.Lang.Object, IConsumer
{
    protected TaskCompletionSource<TResult> _completionSource = new TaskCompletionSource<TResult>();

    public TaskAwaiter<TResult> GetAwaiter()
    {
        return _completionSource.Task.GetAwaiter();
    }

    public void Accept(Java.Lang.Object? t)
    {
        var result = t as ContinueResult;
        if (result?.IsSuccess ?? false)
        {
            try
            {
                _completionSource.TrySetResult(Complete(result.Data));
            }
            catch(Exception e)
            {
                _completionSource.TrySetException(e);
            }
        }
        else
        {
            _completionSource.TrySetException(result?.Throwable ?? new Exception("Error with async method"));
        }
    }

    /// <summary>
    /// Called when the suspending function has been completed.
    /// </summary>
    /// <param name="data">
    /// The return data of the suspending function, or what is in
    /// <see cref="ContinueResult.Data"/>.
    /// </param>
    /// <returns>The .NET return type of the method.</returns>
    protected abstract TResult Complete(Java.Lang.Object? data);
}

/// <summary>
/// A <see cref="IConsumer"/> that is to be passed into the last parameter of a Kotlin
/// suspending function, wrapped in <see cref="Continue.With(IConsumer)"/>, when
/// the return type of the Kotlin suspending function is <see cref="void"/>.
/// </summary>
public class AndroidVoidConsumer : AndroidConsumer<object?>
{
    protected override object? Complete(Java.Lang.Object? t)
    {
        return null;
    }
}

/// <summary>
/// A <see cref="IConsumer"/> that is to be passed into the last parameter of a Kotlin
/// suspending function, wrapped in <see cref="Continue.With(IConsumer)"/>, when
/// the return type of the Kotlin suspending function is <see cref="bool"/>.
/// </summary>
public class AndroidBoolConsumer : AndroidConsumer<bool>, IConsumer
{
    protected override bool Complete(Java.Lang.Object? data)
    {
        if(data != null && (data is Java.Lang.Boolean))
        {
            return ((Java.Lang.Boolean)data!).BooleanValue();
        }

        throw new Exception("Cannot complete consumer, returned data is not Java.Lang.Boolean");
    }
}
