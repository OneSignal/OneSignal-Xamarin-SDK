using System;
using OneSignalSDK.Xamarin.Core;

namespace OneSignalSDK.Xamarin;

/// <summary>
/// This singleton class is the entry point to the OneSignal SDK. It
/// is designed to make OneSignal easy to use.  SDK functionality can
/// be accessed via <see cref="OneSignal.Default"/>.
/// </summary>
public class OneSignal
{
    private static readonly Lazy<IOneSignal> Implementation = new Lazy<IOneSignal>(CreateOneSignal);

    /// <summary>
    /// Access to the OneSignal SDK.
    /// </summary>
    public static IOneSignal Default
    {
        get
        {
            if (Implementation.Value == null)
                throw NotImplementedInReferenceAssembly();

            return Implementation.Value;
        }
    }

    private static IOneSignal CreateOneSignal()
    {
#if XAMARINIOS 
      return new OneSignalSDK.Xamarin.iOS.iOSOneSignal();
#elif MONOANDROID
      return new OneSignalSDK.Xamarin.Android.AndroidOneSignal();
#else
      return null;
#endif

    }

    private static Exception NotImplementedInReferenceAssembly()
    {
        return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
}
