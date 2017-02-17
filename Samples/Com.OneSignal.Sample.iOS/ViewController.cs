using System;
using Com.OneSignal.Sample.Shared;
using UIKit;

namespace Com.OneSignal.Sample.iOS
{
   public partial class ViewController : UIViewController
   {
      protected ViewController(IntPtr handle) : base(handle)
      {
         // Note: this .ctor should not contain any initialization logic.
      }

      public override void ViewDidLoad()
      {
         base.ViewDidLoad();


         // Perform any additional setup after loading the view, typically from a nib.
         Button.AccessibilityIdentifier = "myButton";
         Button.TouchUpInside += delegate
         {
            SharedPush.RegisterIOS();
         };
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.
      }
   }
}
