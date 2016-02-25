using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']"
	[global::Android.Runtime.Register ("com/onesignal/NotificationBundleProcessor", DoNotGenerateAcw=true)]
	public partial class NotificationBundleProcessor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/onesignal/NotificationBundleProcessor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationBundleProcessor); }
		}

		protected NotificationBundleProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']/constructor[@name='NotificationBundleProcessor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NotificationBundleProcessor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NotificationBundleProcessor)) {
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

		static IntPtr id_Process_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']/method[@name='Process' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("Process", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public static unsafe void Process (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_Process_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_Process_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "Process", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Process_Landroid_content_Context_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_bundleAsJSONObject_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']/method[@name='bundleAsJSONObject' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("bundleAsJSONObject", "(Landroid/os/Bundle;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject BundleAsJSONObject (global::Android.OS.Bundle p0)
		{
			if (id_bundleAsJSONObject_Landroid_os_Bundle_ == IntPtr.Zero)
				id_bundleAsJSONObject_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "bundleAsJSONObject", "(Landroid/os/Bundle;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallStaticObjectMethod  (class_ref, id_bundleAsJSONObject_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bundleAsJsonArray_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']/method[@name='bundleAsJsonArray' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("bundleAsJsonArray", "(Landroid/os/Bundle;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray BundleAsJsonArray (global::Android.OS.Bundle p0)
		{
			if (id_bundleAsJsonArray_Landroid_os_Bundle_ == IntPtr.Zero)
				id_bundleAsJsonArray_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "bundleAsJsonArray", "(Landroid/os/Bundle;)Lorg/json/JSONArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_bundleAsJsonArray_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newJsonArray_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='NotificationBundleProcessor']/method[@name='newJsonArray' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("newJsonArray", "(Lorg/json/JSONObject;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray NewJsonArray (global::Org.Json.JSONObject p0)
		{
			if (id_newJsonArray_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_newJsonArray_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "newJsonArray", "(Lorg/json/JSONObject;)Lorg/json/JSONArray;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newJsonArray_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
