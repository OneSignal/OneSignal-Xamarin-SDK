using System;
using Com.OneSignal.Sample.Shared;
using UIKit;

namespace Com.OneSignal.Sample.iOS
{
   public class ExternalIdTextViewDelegate : UITextFieldDelegate
   {
      public override bool ShouldReturn(UITextField textField)
      {
         textField.ResignFirstResponder();
         return false;
      }
   }

   public partial class ViewController : UIViewController 
   {
      ExternalIdTextViewDelegate textDelegate = new ExternalIdTextViewDelegate();

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

         PrivacyConsentControl.SelectedSegment = SharedPush.UserDidProvideConsent() ? 1 : 0;

         UITextField externalIdField = (UITextField)this.View.ViewWithTag(3);

         externalIdField.Delegate = textDelegate;
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.
      }

      partial void ConsentChanged(UISegmentedControl sender)
      {
         SharedPush.ConsentStatusChanged(sender.SelectedSegment == 1);
      }

      partial void SetExternalUserId(UIButton sender)
      {
         UITextField externalIdField = (UITextField)this.View.ViewWithTag(3);
         SharedPush.SetExternalUserId(externalIdField.Text);
      }

      partial void RemoveExternalUserId(UIButton sender)
      {
         SharedPush.RemoveExternalUserId();
      }
   }
}
