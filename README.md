OneSignal Xamarin Push Notification Plugin
==========================================

OneSignal is a free push notification service for mobile apps. This plugin makes it easy to integrate your Xamarin app with OneSignal.

- See https://documentation.onesignal.com/docs/xamarin-sdk-setup for setup documentation.

Getting Started
---------------

* Open ```Example.Shared.Application``` in Xamarin.
* In the Android project's ```AndroidManifest.xml```,
  * Replace ```EDIT_APPID_TO_TEST_THIS_APP``` with your OneSignal Application ID.
  * Replace ```EDIT_GPN_TO_TEST_THIS_APP``` with your Google Project Number.
* In the iOS project's ```Info.plist``` replace ```EDIT_APPID_TO_TEST_THIS_APP``` with your OneSignal Application ID.
* Build and deploy applications to your devices and send a test notification via the OneSignal dashboard.

Contributing
------------

If you would like to contribute to this project, fork this repo and send over a pull request!

### Building the OneSignal Xamarin.Android Binding
* Clone [OneSignal-Android-SDK](https://github.com/one-signal/OneSignal-Android-SDK).
* Build the Android SDK Framework using
```shell
gradle assemble
```
* Import ```onesignal-main.aar``` from there into ```OneSignal.Android.Binding```'s Jars folder.
* Build the binding!
* Import the resultant binding ```OneSignal.Android.Binding.dll``` in your Xamarin.Android application.

### Building the OneSignal Xamarin.iOS Binding
* Clone [OneSignal-iOS-SDK](https://github.com/one-signal/OneSignal-iOS-SDK).
* Build the iOS SDK Framework in Xcode.
* Using the [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/) tool, generate ```ApiDefinitions.cs``` and ```StructAndEnums.cs``` targetting iPhone OS 9.2.
```shell
sharpie bind -framework iOS_SDK/Framework/OneSignal.framework -sdk iphoneos9.2 -namespace Com.OneSignal.iOS
```
* Add the generated ```ApiDefinitions.cs```, ```StructAndEnums.cs```, and the OneSignal library (from ```iOS_SDK/Framework/OneSignal.framework/Versions/A/OneSignal```) into the ```OneSignal.iOS.Binding```.
* Rename the OneSignal library to ```OneSignal.a``` to clearly denote it as a static library.
* In ```ApiDefinitions.cs```, make the following changes:
  * Remove ```using OneSignal;```
  * Remove all ```Verify``` references.
  * Change ```ONE_S_LOG_LEVEL``` references to ```OneSLogLevel```.
* In ```OneSignal.linkwith.cs```, change ```[assembly: LinkWith ("OneSignal.a", SmartLink = true, ForceLoad = true)]``` to ```[assembly: LinkWith ("OneSignal.a", SmartLink = true, ForceLoad = true, Frameworks="SystemConfiguration", LinkerFlags="-ObjC")]```.
* In ```StructAndEnums.cs```, change ```nuint``` to ```ulong```.
* Build the binding!
* Import the resultant binding ```OneSignal.iOS.Binding.dll``` in your Xamarin.iOS application.
