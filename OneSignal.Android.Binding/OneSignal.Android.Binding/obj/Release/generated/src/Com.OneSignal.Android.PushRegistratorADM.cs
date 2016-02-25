using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']"
	[global::Android.Runtime.Register ("com/onesignal/PushRegistratorADM", DoNotGenerateAcw=true)]
	public partial class PushRegistratorADM : global::Java.Lang.Object, global::Com.OneSignal.Android.IPushRegistrator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/onesignal/PushRegistratorADM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushRegistratorADM); }
		}

		protected PushRegistratorADM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/constructor[@name='PushRegistratorADM' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushRegistratorADM ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PushRegistratorADM)) {
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

		static IntPtr id_fireCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/method[@name='fireCallback' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fireCallback", "(Ljava/lang/String;)V", "")]
		public static unsafe void FireCallback (string p0)
		{
			if (id_fireCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_fireCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fireCallback", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fireCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_Handler ()
		{
			if (cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ == null)
				cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_);
			return cb_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
		}

		static void n_RegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.OneSignal.Android.PushRegistratorADM __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.PushRegistratorADM> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler p2 = (global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForPush (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='PushRegistratorADM']/method[@name='registerForPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.PushRegistrator.RegisteredHandler']]"
		[Register ("registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V", "GetRegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_Handler")]
		public virtual unsafe void RegisterForPush (global::Android.Content.Context p0, string p1, global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler p2)
		{
			if (id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ == IntPtr.Zero)
				id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ = JNIEnv.GetMethodID (class_ref, "registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
