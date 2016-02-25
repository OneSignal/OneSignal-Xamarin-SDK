using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='PushRegistrator.RegisteredHandler']"
	[Register ("com/onesignal/PushRegistrator$RegisteredHandler", "", "Com.OneSignal.Android.IPushRegistratorRegisteredHandlerInvoker")]
	public partial interface IPushRegistratorRegisteredHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='PushRegistrator.RegisteredHandler']/method[@name='complete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("complete", "(Ljava/lang/String;)V", "GetComplete_Ljava_lang_String_Handler:Com.OneSignal.Android.IPushRegistratorRegisteredHandlerInvoker, OneSignal.Android.Binding")]
		void Complete (string p0);

	}

	[global::Android.Runtime.Register ("com/onesignal/PushRegistrator$RegisteredHandler", DoNotGenerateAcw=true)]
	internal class IPushRegistratorRegisteredHandlerInvoker : global::Java.Lang.Object, IPushRegistratorRegisteredHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/PushRegistrator$RegisteredHandler");
		IntPtr class_ref;

		public static IPushRegistratorRegisteredHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushRegistratorRegisteredHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.PushRegistrator.RegisteredHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushRegistratorRegisteredHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPushRegistratorRegisteredHandlerInvoker); }
		}

		static Delegate cb_complete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetComplete_Ljava_lang_String_Handler ()
		{
			if (cb_complete_Ljava_lang_String_ == null)
				cb_complete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Complete_Ljava_lang_String_);
			return cb_complete_Ljava_lang_String_;
		}

		static void n_Complete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Complete (p0);
		}
#pragma warning restore 0169

		IntPtr id_complete_Ljava_lang_String_;
		public unsafe void Complete (string p0)
		{
			if (id_complete_Ljava_lang_String_ == IntPtr.Zero)
				id_complete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "complete", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_complete_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='PushRegistrator']"
	[Register ("com/onesignal/PushRegistrator", "", "Com.OneSignal.Android.IPushRegistratorInvoker")]
	public partial interface IPushRegistrator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='PushRegistrator']/method[@name='registerForPush' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.onesignal.PushRegistrator.RegisteredHandler']]"
		[Register ("registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V", "GetRegisterForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_Handler:Com.OneSignal.Android.IPushRegistratorInvoker, OneSignal.Android.Binding")]
		void RegisterForPush (global::Android.Content.Context p0, string p1, global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler p2);

	}

	[global::Android.Runtime.Register ("com/onesignal/PushRegistrator", DoNotGenerateAcw=true)]
	internal class IPushRegistratorInvoker : global::Java.Lang.Object, IPushRegistrator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/PushRegistrator");
		IntPtr class_ref;

		public static IPushRegistrator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushRegistrator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.PushRegistrator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushRegistratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPushRegistratorInvoker); }
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
			global::Com.OneSignal.Android.IPushRegistrator __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IPushRegistrator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler p2 = (global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForPush (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_;
		public unsafe void RegisterForPush (global::Android.Content.Context p0, string p1, global::Com.OneSignal.Android.IPushRegistratorRegisteredHandler p2)
		{
			if (id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ == IntPtr.Zero)
				id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_ = JNIEnv.GetMethodID (class_ref, "registerForPush", "(Landroid/content/Context;Ljava/lang/String;Lcom/onesignal/PushRegistrator$RegisteredHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_registerForPush_Landroid_content_Context_Ljava_lang_String_Lcom_onesignal_PushRegistrator_RegisteredHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
