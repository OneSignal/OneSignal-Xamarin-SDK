using ObjCRuntime;

[assembly: LinkWith ("OneSignal.a", SmartLink = true, ForceLoad = true, Frameworks="SystemConfiguration", LinkerFlags="-ObjC")]
