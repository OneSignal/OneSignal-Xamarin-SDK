// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Com.OneSignal.Sample.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }


        [Outlet]
        UIKit.UITextField OutcomeKey { get; set; }


        [Outlet]
        UIKit.UITextField OutcomeValue { get; set; }


        [Outlet]
        UIKit.UITextField OutcomeValueKey { get; set; }


        [Outlet]
        UIKit.UITextField UniqueOutcomeKey { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl PrivacyConsentControl { get; set; }


        [Action ("Button_TouchUpInside:")]
        partial void Button_TouchUpInside (UIKit.UIButton sender);


        [Action ("ConsentChanged:")]
        partial void ConsentChanged (UIKit.UISegmentedControl sender);


        [Action ("ExternalIdChanged:")]
        partial void ExternalIdChanged (UIKit.UITextField sender);


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

        void ReleaseDesignerOutlets ()
        {
            if (PrivacyConsentControl != null) {
                PrivacyConsentControl.Dispose ();
                PrivacyConsentControl = null;
            }
        }
    }
}