// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OneSignalApp.Sample.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UITextField OutcomeKey { get; set; }

		[Outlet]
		UIKit.UITextField OutcomeValue { get; set; }

		[Outlet]
		UIKit.UITextField OutcomeValueKey { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UISegmentedControl PrivacyConsentControl { get; set; }

		[Outlet]
		UIKit.UITextField UniqueOutcomeKey { get; set; }

      [Outlet]
      UIKit.UITextField ActivityID { get; set; }

      [Action ("Button_TouchUpInside:")]
		partial void Button_TouchUpInside (UIKit.UIButton sender);

		[Action ("ConsentChanged:")]
		partial void ConsentChanged (UIKit.UISegmentedControl sender);

		[Action ("ExternalIdChanged:")]
		partial void ExternalIdChanged (UIKit.UITextField sender);

		[Action ("RegisterForPush:")]
		partial void RegisterForPush (UIKit.UIButton sender);

		[Action ("RemoveExternalUserId:")]
		partial void RemoveExternalUserId (UIKit.UIButton sender);

		[Action ("SendOutcome:")]
		partial void SendOutcome (UIKit.UIButton sender);

		[Action ("SendOutcomeWithValue:")]
		partial void SendOutcomeWithValue (UIKit.UIButton sender);

		[Action ("SendUniqueOutcome:")]
		partial void SendUniqueOutcome (UIKit.UIButton sender);

		[Action ("SetExternalUserId:")]
		partial void SetExternalUserId (UIKit.UIButton sender);

      [Action("EnterLiveActivity:")]
      partial void EnterLiveActivity(UIKit.UIButton sender);

      [Action("ExitLiveActivity:")]
      partial void ExitLiveActivity(UIKit.UIButton sender);

      void ReleaseDesignerOutlets ()
		{
			if (OutcomeKey != null) {
				OutcomeKey.Dispose ();
				OutcomeKey = null;
			}

			if (OutcomeValue != null) {
				OutcomeValue.Dispose ();
				OutcomeValue = null;
			}

			if (OutcomeValueKey != null) {
				OutcomeValueKey.Dispose ();
				OutcomeValueKey = null;
			}

			if (UniqueOutcomeKey != null) {
				UniqueOutcomeKey.Dispose ();
				UniqueOutcomeKey = null;
			}

			if (PrivacyConsentControl != null) {
				PrivacyConsentControl.Dispose ();
				PrivacyConsentControl = null;
			}
		}
	}
}
