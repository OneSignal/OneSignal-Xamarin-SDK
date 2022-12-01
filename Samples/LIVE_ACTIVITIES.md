The Live Activities functionality is disabled by default as it requires manual work for the solution to successfull build.
This example is based off the work of https://github.com/chamons/xamarin-ios-swift-extension, which is an example of how to add a native Widget to a Xamarin application.

There are 2 additional components required to establish a Live Activity from a Xamarin application:

1. Creation of a native LiveActivity Widget, building it natively, then importing it into the Xamarin project via the `AdditionalAppExtensions` csproj target.
2. Creation of a native framework which starts the LiveActivity Widget, along with a standard iOS Binding project to invoke that behavior.

To enable this functionality in the sample app, you must do the following on a mac:

1. Using Xcode, open `Samples/native/example/example.xcodeproj`.
2. Go to menu File -> Project Settings and change `Derived Data` to `Project-relative Location` with path `DerivedData`.
3. Build the product for iPhone and/or the iPhoneSimulator, which will populate the `Derived Data` directory with the build output.
4. Using Visual Studio, open `OneSignal.sln`.
5. Within `Samples/OneSignalApp.Sample.iOS/OneSignalApp.Sample.iOS.csproj` Add `LIVE_ACTIVITIES` to `DefineConstants` as a compiler conditional symbol for the appropriate platform/targets.
6. Change the platform to either `iPhone` or `iPhoneSimulator`, then build/run as the startup project `OneSignalApp.Sample.iOS`!