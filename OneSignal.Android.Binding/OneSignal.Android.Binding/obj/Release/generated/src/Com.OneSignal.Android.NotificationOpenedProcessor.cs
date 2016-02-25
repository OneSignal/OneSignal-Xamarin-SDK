using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationOpenedProcessor']"
	[global::Android.Runtime.Register ("com/onesignal/NotificationOpenedProcessor", DoNotGenerateAcw=true)]
	public partial class NotificationOpenedProcessor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/onesignal/NotificationOpenedProcessor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationOpenedProcessor); }
		}

		protected NotificationOpenedProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationOpenedProcessor']/constructor[@name='NotificationOpenedProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NotificationOpenedProcessor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NotificationOpenedProcessor)) {
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

		static IntPtr id_processFromActivity_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationOpenedProcessor']/method[@name='processFromActivity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("processFromActivity", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void ProcessFromActivity (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_processFromActivity_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_processFromActivity_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "processFromActivity", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processFromActivity_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

	}
}
