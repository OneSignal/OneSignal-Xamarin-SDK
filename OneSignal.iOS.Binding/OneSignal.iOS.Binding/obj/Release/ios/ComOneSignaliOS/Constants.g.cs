//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Com.OneSignal.iOS {
	public unsafe static partial class Constants  {
		
		[CompilerGenerated]
		static NSString _ONESIGNAL_VERSION;
		[Field ("ONESIGNAL_VERSION",  "__Internal")]
		public static unsafe NSString ONESIGNAL_VERSION {
			get {
				if (_ONESIGNAL_VERSION == null)
					_ONESIGNAL_VERSION = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "ONESIGNAL_VERSION");
				return _ONESIGNAL_VERSION;
			}
		}
	} /* class Constants */
}
