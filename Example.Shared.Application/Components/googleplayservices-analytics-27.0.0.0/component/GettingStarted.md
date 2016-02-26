The Google Analytics SDK for Android makes it easy for developers to collect user engagement data form their apps. 

Required Android API Levels
===========================

We recommend setting your app's *Target Framework* and *Target Android version* to **Android 5.0 (API Level 21)** or higher in your app project settings.

This Google Play Service SDK's requires a *Target Framework* of at least Android 4.1 (API Level 16) to compile.

You may still set a lower *Minimum Android version* (as low as Android 2.3 - API Level 9) so your app will run on older versions of Android, however you must ensure you do not use any API's at runtime that are not available on the version of Android your app is running on.


Android Manifest 
================

Some Google Play Services APIs require specific metadata, attributes, permissions or features to be declared in your *AndroidManifest.xml* file.

These can be added manually to the *AndroidManifest.xml* file, or merged in through the use of assembly level attributes.


The Google Analytics SDK requires the *Internet* and *Access Network State* permissions to work correctly.  You can include these by adding the following assembly level attributes to your app:

```csharp
[assembly: UsesPermission (Android.Manifest.Permission.Internet)]
[assembly: UsesPermission (Android.Manifest.Permission.AccessNetworkState)]
```

If you want to add Campaign tracking you must manually add the following element to your *AndroidManifest.xml* file, inside of the `<application>` `</application>` tags:

```xml
<service android:name="com.google.analytics.tracking.android.CampaignTrackingService" />
<receiver android:name="com.google.analytics.tracking.android.CampaignTrackingReceiver"
          android:exported="true" >
  <intent-filter>
    <action android:name="com.android.vending.INSTALL_REFERRER" />
  </intent-filter>
</receiver>
```



Samples
=======

You can find a Sample Application within each Google Play Services component.  The sample will demonstrate the necessary configuration and some basic API usages.





Learn More
==========

You can learn more about the various Google Play Services SDKs & APIs by visiting the official [Google APIs for Android][3] documentation


You can learn more about Google Play Services Analytics by visiting the official [Analytics SDK for Android](https://developers.google.com/analytics/devguides/collection/android/v4/) documentation.

[1]: https://console.developers.google.com/ "Google Developers Console"
[2]: https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/MD5_SHA1/ "Finding your SHA-1 Fingerprints"
[3]: https://developers.google.com/android/ "Google APIs for Android"

