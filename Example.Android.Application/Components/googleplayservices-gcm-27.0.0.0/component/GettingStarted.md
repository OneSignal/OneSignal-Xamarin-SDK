Google Cloud Messaging (GCM) is a free service that enables developers to send messages between servers and client apps. This includes downstream messages from servers to client apps, and upstream messages from client apps to servers.

For example, a lightweight downstream message could inform a client app that there is new data to be fetched from the server, as in the case of a "new email" notification. For use cases such as instant messaging, a GCM message can transfer up to 4kb of payload to the client app. The GCM service handles all aspects of queueing of messages and delivery to and from the target client app.



Required Android API Levels
===========================

We recommend setting your app's *Target Framework* and *Target Android version* to **Android 5.0 (API Level 21)** or higher in your app project settings.

This Google Play Service SDK's requires a *Target Framework* of at least Android 4.1 (API Level 16) to compile.

You may still set a lower *Minimum Android version* (as low as Android 2.3 - API Level 9) so your app will run on older versions of Android, however you must ensure you do not use any API's at runtime that are not available on the version of Android your app is running on.




Google Developers Console Setup
=================================

Many of the Google Play Services SDK's require that you create an application inside the [Google Developers Console][1].  Visit the [Google Developers Console][1] to create a project for your application.

Once you have created a project for your Android app, enable the necessary APIs in the developer console for the Google Play Services APIs you will be using in your app.



To use the Fitness API in your Android app, you must enable the *Cloud Messaging for Android* in the Google Developers Console, under *APIs and Auth*.



Android Manifest 
================

Some Google Play Services APIs require specific metadata, attributes, permissions or features to be declared in your *AndroidManifest.xml* file.

These can be added manually to the *AndroidManifest.xml* file, or merged in through the use of assembly level attributes.


Cloud Messaging requires the *Internet*, *WakeLock*, and *com.google.android.c2dm.permission.RECEIVE* permissions.  You add these by including the following assembly level attributes in your app:

```csharp
[assembly: UsesPermission (Android.Manifest.Permission.Internet)]
[assembly: UsesPermission (Android.Manifest.Permission.WakeLock)]
[assembly: UsesPermission ("com.google.android.c2dm.permission.RECEIVE)]
```

You will also need to declare and use a special permission in your manifest file.  Again, you can use the following attributes (note that @PACKAGE_NAME@ is a macro that will be replaced at compile time with your app's actual package name):

```csharp
[assembly: Permission ("@PACKAGE_NAME@.permission.C2D_MESSAGE")]
[assembly: UsesPermission ("@PACKAGE_NAME@.permission.C2D_MESSAGE")]
```



Samples
=======

You can find a Sample Application within each Google Play Services component.  The sample will demonstrate the necessary configuration and some basic API usages.






Learn More
==========

You can learn more about the various Google Play Services SDKs & APIs by visiting the official [Google APIs for Android][3] documentation


You can learn more about Google Play Services GCM by visiting the official [Google Cloud Messaging for Android](https://developers.google.com/cloud-messaging/android/start) documentation.



[1]: https://console.developers.google.com/ "Google Developers Console"
[2]: https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/MD5_SHA1/ "Finding your SHA-1 Fingerprints"
[3]: https://developers.google.com/android/ "Google APIs for Android"

