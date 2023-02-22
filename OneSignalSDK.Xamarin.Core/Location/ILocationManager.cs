using static System.Net.WebRequestMethods;
using System.Security;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace OneSignalSDK.Xamarin.Core.Location;

/// <summary>
/// The entry point to the location SDK for OneSignal.
/// </summary>
public interface ILocationManager
{
    /// <summary>
    /// Whether location is currently shared with OneSignal.
    /// </summary>
    bool IsShared { get; set; }

    /// <summary>
    /// Use this method to manually prompt the user for location permissions.
    /// This allows for geotagging so you send notifications to users based on location.
    ///
    /// Make sure you have one of the following permission in your `AndroidManifest.xml` as well.
    ///
    /// <code>
    /// <uses-permission android:name= "android.permission.ACCESS_FINE_LOCATION" />
    /// <uses-permission android:name= "android.permission.ACCESS_COARSE_LOCATION" />
    /// </code>
    ///
    /// Be aware of best practices regarding asking permissions on Android:
    /// <a href="https://developer.android.com/guide/topics/permissions/requesting.html">Requesting Permissions | Android Developers</a>
    ///
    /// See <a href="https://documentation.onesignal.com/docs/permission-requests">Permission Requests | OneSignal Docs</a>
    /// </summary>
    /// <returns>
    /// A task which will complete once the permission request has completed. The result
    /// is true if the user is opted in to location permission (user affirmed or already enabled),
    /// the result is false if the user is opted out of location permission(user rejected).
    /// </returns>
    Task<bool> RequestPermissionAsync();
}