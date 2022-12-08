using System;
using Foundation;

namespace OneSignalLiveActivity.Binding
{
   // @interface OneSignalLiveActivity : NSObject
   [BaseType(typeof(NSObject))]
   interface OneSignalLiveActivity
   {
      // -(void)startLiveActivityWithRecievedToken:(void (^ _Nonnull)(NSString * _Nonnull))recievedToken;
      [Export("startLiveActivityWithRecievedToken:")]
      void StartLiveActivityWithRecievedToken(Action<NSString> recievedToken);
   }
}
