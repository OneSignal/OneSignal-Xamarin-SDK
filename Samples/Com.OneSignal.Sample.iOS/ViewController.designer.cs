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
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl PrivacyConsentControl { get; set; }

        [Action ("ConsentChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ConsentChanged (UIKit.UISegmentedControl sender);

        [Action ("RemoveExternalUserId:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RemoveExternalUserId (UIKit.UIButton sender);

        [Action ("SetExternalUserId:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SetExternalUserId (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (PrivacyConsentControl != null) {
                PrivacyConsentControl.Dispose ();
                PrivacyConsentControl = null;
            }
        }
    }
}