using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Stericson.RootTools.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stericson.RootTools.internal']/class[@name='RootToolsInternalMethods']"
	[global::Android.Runtime.Register ("com/stericson/RootTools/internal/RootToolsInternalMethods", DoNotGenerateAcw=true)]
	public partial class RootToolsInternalMethods : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/stericson/RootTools/internal/RootToolsInternalMethods", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RootToolsInternalMethods); }
		}

		protected RootToolsInternalMethods (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.stericson.RootTools.internal']/class[@name='RootToolsInternalMethods']/constructor[@name='RootToolsInternalMethods' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RootToolsInternalMethods ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RootToolsInternalMethods)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isRooted;
		public static unsafe bool IsRooted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.stericson.RootTools.internal']/class[@name='RootToolsInternalMethods']/method[@name='isRooted' and count(parameter)=0]"
			[Register ("isRooted", "()Z", "GetIsRootedHandler")]
			get {
				if (id_isRooted == IntPtr.Zero)
					id_isRooted = JNIEnv.GetStaticMethodID (class_ref, "isRooted", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRooted);
				} finally {
				}
			}
		}

	}
}
