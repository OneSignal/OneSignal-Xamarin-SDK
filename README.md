<p align="center">
  <img src="https://media.onesignal.com/cms/Website%20Layout/logo-red.svg"/>
</p>

### OneSignal Xamarin SDK
[![NuGet](https://img.shields.io/nuget/v/Com.OneSignal.svg?label=NuGet)](https://www.nuget.org/packages/Com.OneSignal)

---

[OneSignal](https://onesignal.com) is a free push notification service for mobile apps. This plugin makes it easy to integrate your Xamarin application with OneSignal.

<p align="center"><img src="https://app.onesignal.com/images/android_and_ios_notification_image.gif" width="400" alt="Xamarin Notification"></p>

#### Installation and Setup
See the [Setup Documentation](https://documentation.onesignal.com/docs/xamarin-sdk-setup) for installation and setup instructions.

#### API
See OneSignal's [Xamarin SDK API](https://documentation.onesignal.com/docs/xamarin-sdk) page for a list of all available methods.

#### Change Log
See this repository's [release tags](https://github.com/OneSignal/OneSignal-Xamarin-SDK/releases) for a complete change log of every released version.

#### Support
Please visit this repository's [Github issue tracker](https://github.com/OneSignal/OneSignal-Xamarin-SDK/issues) for feature requests and bug reports related specificly to the SDK.

For account issues and support please contact OneSignal support from the [OneSignal.com](https://onesignal.com) dashboard.

#### Sample Project
To make it easier to become familiar with our SDK, we have included a sample project.
* Open ```Example.Shared.Application``` in Xamarin.
* In the Android project's ```AndroidManifest.xml```,
  * Replace ```EDIT_APPID_TO_TEST_THIS_APP``` with your OneSignal Application ID.
  * Replace ```EDIT_GPN_TO_TEST_THIS_APP``` with your Google Project Number.
* In the iOS project's ```Info.plist``` replace ```EDIT_APPID_TO_TEST_THIS_APP``` with your OneSignal Application ID.
* Build and deploy applications to your devices and send a test notification via the OneSignal dashboard.

#### Supports:
* iOS 7 - 13
* Android 4.0.3 (API Level 15) through 9 (API Level 28)
* Xamarin Forms and Single View projects
