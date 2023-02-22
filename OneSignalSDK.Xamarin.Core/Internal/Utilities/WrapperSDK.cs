using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OneSignalSDK.Xamarin.Core.Internal.Utilities;

public static class WrapperSDK {

    public static string Type = "dotnet";

    public static string? Version
    {
        get
        {
            var version = typeof(WrapperSDK).Assembly.GetName().Version;
            if (version == null)
                return null;

            return $"{version.Major:D2}{version.Minor:D2}{version.Build:D2}";
        }
    }
}