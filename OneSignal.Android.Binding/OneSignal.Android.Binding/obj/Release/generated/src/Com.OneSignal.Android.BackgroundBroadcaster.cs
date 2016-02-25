using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='BackgroundBroadcaster']"
	[global::Android.Runtime.Register ("com/onesignal/BackgroundBroadcaster", DoNotGenerateAcw=true)]
	public partial class BackgroundBroadcaster : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/onesignal/BackgroundBroadcaster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundBroadcaster); }
		}

		protected BackgroundBroadcaster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='BackgroundBroadcaster']/constructor[@name='BackgroundBroadcaster' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BackgroundBroadcaster ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BackgroundBroadcaster)) {
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

		static IntPtr id_Invoke_Landroid_content_Context_Landroid_os_Bundle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='BackgroundBroadcaster']/method[@name='Invoke' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='boolean']]"
		[Register ("Invoke", "(Landroid/content/Context;Landroid/os/Bundle;Z)V", "")]
		public static unsafe void Invoke (global::Android.Content.Context p0, global::Android.OS.Bundle p1, bool p2)
		{
			if (id_Invoke_Landroid_content_Context_Landroid_os_Bundle_Z == IntPtr.Zero)
				id_Invoke_Landroid_content_Context_Landroid_os_Bundle_Z = JNIEnv.GetStaticMethodID (class_ref, "Invoke", "(Landroid/content/Context;Landroid/os/Bundle;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Invoke_Landroid_content_Context_Landroid_os_Bundle_Z, __args);
			} finally {
			}
		}

	}
}
