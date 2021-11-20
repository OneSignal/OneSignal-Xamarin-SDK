using System;
using Com.OneSignal.Sample.Shared;
using System.Globalization;
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

         PrivacyConsentControl.SelectedSegment = OneSignal.Default.PrivacyConsent ? 1 : 0;

         UITextField externalIdField = (UITextField)this.View.ViewWithTag(3);

         externalIdField.Delegate = textDelegate;
      }

      public override void DidReceiveMemoryWarning()
      {
         base.DidReceiveMemoryWarning();
         // Release any cached data, images, etc that aren't in use.
      }

      partial void RegisterForPush(UIButton sender)
      {
         SharedPush.RegisterIOS();
      }

      partial void ConsentChanged(UISegmentedControl sender)
      {
         SharedPush.ConsentStatusChanged(sender.SelectedSegment == 1);
      }

      partial void SetExternalUserId(UIButton sender)
      {
         UITextField externalIdField = (UITextField)this.View.ViewWithTag(3);
         OneSignal.Default.SetExternalUserId(externalIdField.Text);
      }

      partial void RemoveExternalUserId(UIButton sender)
      {
         OneSignal.Default.Logout(Core.LogoutOptions.ExternalUserId);
      }

      partial void SendOutcome(UIButton sender)
      {
         string name = OutcomeKey.Text;
         SharedPush.SendOutcome(name);
      }

      partial void SendUniqueOutcome(UIButton sender)
      {
         string name = UniqueOutcomeKey.Text;
         SharedPush.SendUniqueOutcome(name);
      }

      partial void SendOutcomeWithValue(UIButton sender)
      {
         string name = OutcomeValueKey.Text;
         float value = float.Parse(OutcomeValue.Text);
         SharedPush.SendOutcomeWithValue(name, value);
      }

   }
}
