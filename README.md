OneSignal Xamarin Push Notification Plugin
==========================================

OneSignal is a free push notification service for mobile apps. This plugin makes it easy to integrate your Xamarin app with OneSignal.

- See http://documentation.onesignal.com/v2.0/docs/using-onesignal-in-your-xamarin-sdk-app for setup documentation.
- See http://documentation.onesignal.com/v2.0/docs/onesignal-xamarin-sdk-api for OneSignal API documentation.

Contributing
------------

If you would like to contribute to this project, fork this repo and send over a pull request!

### Building the OneSignal Xamarin.iOS Binding
* Clone [OneSignal-iOS-SDK](https://github.com/one-signal/OneSignal-iOS-SDK).
* Build the iOS SDK Framework in Xcode.
* Using the [Objective Sharpie](https://developer.xamarin.com/guides/cross-platform/macios/binding/objective-sharpie/) tool, generate ```ApiDefinitions.cs``` and ```StructAndEnums.cs``` targetting iPhone OS 9.2.
```shell
sharpie bind -framework iOS_SDK/Framework/OneSignal.framework -sdk iphoneos9.2
```
* Add ```ApiDefinitions.cs```, ```StructAndEnums.cs```, and the OneSignal library (from ```iOS_SDK/Framework/OneSignal.framework/Versions/A/OneSignal```) into a Xamarin.iOS Bindings Library solution.
* Rename the OneSignal library to ```OneSignal.a``` to clearly denote it as a static library.
* In ```ApiDefinitions.cs```, make the following changes:
  * Remove ```using OneSignal;```
  * Remove all ```Verify``` references.
  * Change ```ONE_S_LOG_LEVEL``` references to ```OneSLogLevel```.
* In ```OneSignal.linkwith.cs```, change ```[assembly: LinkWith ("OneSignal.a", SmartLink = true, ForceLoad = true)]``` to ```[assembly: LinkWith ("OneSignal.a", SmartLink = true, ForceLoad = true, Frameworks="SystemConfiguration", LinkerFlags="-ObjC")]```.
* In ```StructAndEnums.cs```, change ```nuint``` to ```ulong```.
* After you get a error building the solution, remove the ```namespace {}``` enclosure in ```SupportDelegates.g.cs```. Save the file and build again to successfully the build the solution.