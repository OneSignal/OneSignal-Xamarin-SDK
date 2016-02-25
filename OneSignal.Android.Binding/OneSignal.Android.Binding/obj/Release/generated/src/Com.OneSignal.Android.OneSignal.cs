using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.OneSignal.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']"
	[global::Android.Runtime.Register ("com/onesignal/OneSignal", DoNotGenerateAcw=true)]
	public partial class OneSignal : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "020101";

		static IntPtr sdkType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/field[@name='sdkType']"
		[Register ("sdkType")]
		public static string SdkType {
			get {
				if (sdkType_jfieldId == IntPtr.Zero)
					sdkType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sdkType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sdkType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sdkType_jfieldId == IntPtr.Zero)
					sdkType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sdkType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, sdkType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.Builder']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/onesignal/OneSignal$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_init;
#pragma warning disable 0169
			static Delegate GetInitHandler ()
			{
				if (cb_init == null)
					cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
				return cb_init;
			}

			static void n_Init (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.OneSignal.Android.OneSignal.Builder __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Init ();
			}
#pragma warning restore 0169

			static IntPtr id_init;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.Builder']/method[@name='init' and count(parameter)=0]"
			[Register ("init", "()V", "GetInitHandler")]
			public virtual unsafe void Init ()
			{
				if (id_init == IntPtr.Zero)
					id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_init);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
				} finally {
				}
			}

			static Delegate cb_setAutoPromptLocation_Z;
#pragma warning disable 0169
			static Delegate GetSetAutoPromptLocation_ZHandler ()
			{
				if (cb_setAutoPromptLocation_Z == null)
					cb_setAutoPromptLocation_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAutoPromptLocation_Z);
				return cb_setAutoPromptLocation_Z;
			}

			static IntPtr n_SetAutoPromptLocation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.OneSignal.Android.OneSignal.Builder __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAutoPromptLocation (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setAutoPromptLocation_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.Builder']/method[@name='setAutoPromptLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoPromptLocation", "(Z)Lcom/onesignal/OneSignal$Builder;", "GetSetAutoPromptLocation_ZHandler")]
			public virtual unsafe global::Com.OneSignal.Android.OneSignal.Builder SetAutoPromptLocation (bool p0)
			{
				if (id_setAutoPromptLocation_Z == IntPtr.Zero)
					id_setAutoPromptLocation_Z = JNIEnv.GetMethodID (class_ref, "setAutoPromptLocation", "(Z)Lcom/onesignal/OneSignal$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAutoPromptLocation_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoPromptLocation", "(Z)Lcom/onesignal/OneSignal$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_;
#pragma warning disable 0169
			static Delegate GetSetNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_Handler ()
			{
				if (cb_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ == null)
					cb_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_);
				return cb_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_;
			}

			static IntPtr n_SetNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.OneSignal.Android.OneSignal.Builder __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler p0 = (global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler)global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNotificationOpenedHandler (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.Builder']/method[@name='setNotificationOpenedHandler' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.NotificationOpenedHandler']]"
			[Register ("setNotificationOpenedHandler", "(Lcom/onesignal/OneSignal$NotificationOpenedHandler;)Lcom/onesignal/OneSignal$Builder;", "GetSetNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_Handler")]
			public virtual unsafe global::Com.OneSignal.Android.OneSignal.Builder SetNotificationOpenedHandler (global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler p0)
			{
				if (id_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ == IntPtr.Zero)
					id_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ = JNIEnv.GetMethodID (class_ref, "setNotificationOpenedHandler", "(Lcom/onesignal/OneSignal$NotificationOpenedHandler;)Lcom/onesignal/OneSignal$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.OneSignal.Android.OneSignal.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNotificationOpenedHandler_Lcom_onesignal_OneSignal_NotificationOpenedHandler_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationOpenedHandler", "(Lcom/onesignal/OneSignal$NotificationOpenedHandler;)Lcom/onesignal/OneSignal$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.GetTagsHandler']"
		[Register ("com/onesignal/OneSignal$GetTagsHandler", "", "Com.OneSignal.Android.OneSignal/IGetTagsHandlerInvoker")]
		public partial interface IGetTagsHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.GetTagsHandler']/method[@name='tagsAvailable' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("tagsAvailable", "(Lorg/json/JSONObject;)V", "GetTagsAvailable_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IGetTagsHandlerInvoker, OneSignal.Android.Binding")]
			void TagsAvailable (global::Org.Json.JSONObject p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$GetTagsHandler", DoNotGenerateAcw=true)]
		internal class IGetTagsHandlerInvoker : global::Java.Lang.Object, IGetTagsHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/OneSignal$GetTagsHandler");
			IntPtr class_ref;

			public static IGetTagsHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IGetTagsHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.OneSignal.GetTagsHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IGetTagsHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IGetTagsHandlerInvoker); }
			}

			static Delegate cb_tagsAvailable_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetTagsAvailable_Lorg_json_JSONObject_Handler ()
			{
				if (cb_tagsAvailable_Lorg_json_JSONObject_ == null)
					cb_tagsAvailable_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TagsAvailable_Lorg_json_JSONObject_);
				return cb_tagsAvailable_Lorg_json_JSONObject_;
			}

			static void n_TagsAvailable_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.OneSignal.Android.OneSignal.IGetTagsHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IGetTagsHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.TagsAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_tagsAvailable_Lorg_json_JSONObject_;
			public unsafe void TagsAvailable (global::Org.Json.JSONObject p0)
			{
				if (id_tagsAvailable_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_tagsAvailable_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "tagsAvailable", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_tagsAvailable_Lorg_json_JSONObject_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.IdsAvailableHandler']"
		[Register ("com/onesignal/OneSignal$IdsAvailableHandler", "", "Com.OneSignal.Android.OneSignal/IIdsAvailableHandlerInvoker")]
		public partial interface IIdsAvailableHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.IdsAvailableHandler']/method[@name='idsAvailable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("idsAvailable", "(Ljava/lang/String;Ljava/lang/String;)V", "GetIdsAvailable_Ljava_lang_String_Ljava_lang_String_Handler:Com.OneSignal.Android.OneSignal/IIdsAvailableHandlerInvoker, OneSignal.Android.Binding")]
			void IdsAvailable (string p0, string p1);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$IdsAvailableHandler", DoNotGenerateAcw=true)]
		internal class IIdsAvailableHandlerInvoker : global::Java.Lang.Object, IIdsAvailableHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/OneSignal$IdsAvailableHandler");
			IntPtr class_ref;

			public static IIdsAvailableHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IIdsAvailableHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.OneSignal.IdsAvailableHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IIdsAvailableHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IIdsAvailableHandlerInvoker); }
			}

			static Delegate cb_idsAvailable_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIdsAvailable_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_idsAvailable_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_idsAvailable_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_IdsAvailable_Ljava_lang_String_Ljava_lang_String_);
				return cb_idsAvailable_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_IdsAvailable_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.OneSignal.Android.OneSignal.IIdsAvailableHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IIdsAvailableHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.IdsAvailable (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_idsAvailable_Ljava_lang_String_Ljava_lang_String_;
			public unsafe void IdsAvailable (string p0, string p1)
			{
				if (id_idsAvailable_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_idsAvailable_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "idsAvailable", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (Handle, id_idsAvailable_Ljava_lang_String_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']"
		[global::Android.Runtime.Register ("com/onesignal/OneSignal$LOG_LEVEL", DoNotGenerateAcw=true)]
		public sealed partial class LOG_LEVEL : global::Java.Lang.Enum {


			static IntPtr DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Debug {
				get {
					if (DEBUG_jfieldId == IntPtr.Zero)
						DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FATAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='FATAL']"
			[Register ("FATAL")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Fatal {
				get {
					if (FATAL_jfieldId == IntPtr.Zero)
						FATAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FATAL", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FATAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Info {
				get {
					if (INFO_jfieldId == IntPtr.Zero)
						INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VERBOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='VERBOSE']"
			[Register ("VERBOSE")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Verbose {
				get {
					if (VERBOSE_jfieldId == IntPtr.Zero)
						VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERBOSE", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERBOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Com.OneSignal.Android.OneSignal.LOG_LEVEL Warn {
				get {
					if (WARN_jfieldId == IntPtr.Zero)
						WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lcom/onesignal/OneSignal$LOG_LEVEL;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/onesignal/OneSignal$LOG_LEVEL", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LOG_LEVEL); }
			}

			internal LOG_LEVEL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$LOG_LEVEL;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.LOG_LEVEL ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/onesignal/OneSignal$LOG_LEVEL;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.OneSignal.Android.OneSignal.LOG_LEVEL __ret = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.LOG_LEVEL> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal.LOG_LEVEL']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/onesignal/OneSignal$LOG_LEVEL;", "")]
			public static unsafe global::Com.OneSignal.Android.OneSignal.LOG_LEVEL[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/onesignal/OneSignal$LOG_LEVEL;");
				try {
					return (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.NotificationOpenedHandler']"
		[Register ("com/onesignal/OneSignal$NotificationOpenedHandler", "", "Com.OneSignal.Android.OneSignal/INotificationOpenedHandlerInvoker")]
		public partial interface INotificationOpenedHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.NotificationOpenedHandler']/method[@name='notificationOpened' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='boolean']]"
			[Register ("notificationOpened", "(Ljava/lang/String;Lorg/json/JSONObject;Z)V", "GetNotificationOpened_Ljava_lang_String_Lorg_json_JSONObject_ZHandler:Com.OneSignal.Android.OneSignal/INotificationOpenedHandlerInvoker, OneSignal.Android.Binding")]
			void NotificationOpened (string p0, global::Org.Json.JSONObject p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$NotificationOpenedHandler", DoNotGenerateAcw=true)]
		internal class INotificationOpenedHandlerInvoker : global::Java.Lang.Object, INotificationOpenedHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/OneSignal$NotificationOpenedHandler");
			IntPtr class_ref;

			public static INotificationOpenedHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INotificationOpenedHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.OneSignal.NotificationOpenedHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INotificationOpenedHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INotificationOpenedHandlerInvoker); }
			}

			static Delegate cb_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z;
#pragma warning disable 0169
			static Delegate GetNotificationOpened_Ljava_lang_String_Lorg_json_JSONObject_ZHandler ()
			{
				if (cb_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z == null)
					cb_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_NotificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z);
				return cb_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z;
			}

			static void n_NotificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
			{
				global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.NotificationOpened (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z;
			public unsafe void NotificationOpened (string p0, global::Org.Json.JSONObject p1, bool p2)
			{
				if (id_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z == IntPtr.Zero)
					id_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z = JNIEnv.GetMethodID (class_ref, "notificationOpened", "(Ljava/lang/String;Lorg/json/JSONObject;Z)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_notificationOpened_Ljava_lang_String_Lorg_json_JSONObject_Z, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']"
		[Register ("com/onesignal/OneSignal$PostNotificationResponseHandler", "", "Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker")]
		public partial interface IPostNotificationResponseHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onFailure", "(Lorg/json/JSONObject;)V", "GetOnFailure_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignal.Android.Binding")]
			void OnFailure (global::Org.Json.JSONObject p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/interface[@name='OneSignal.PostNotificationResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("onSuccess", "(Lorg/json/JSONObject;)V", "GetOnSuccess_Lorg_json_JSONObject_Handler:Com.OneSignal.Android.OneSignal/IPostNotificationResponseHandlerInvoker, OneSignal.Android.Binding")]
			void OnSuccess (global::Org.Json.JSONObject p0);

		}

		[global::Android.Runtime.Register ("com/onesignal/OneSignal$PostNotificationResponseHandler", DoNotGenerateAcw=true)]
		internal class IPostNotificationResponseHandlerInvoker : global::Java.Lang.Object, IPostNotificationResponseHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/onesignal/OneSignal$PostNotificationResponseHandler");
			IntPtr class_ref;

			public static IPostNotificationResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPostNotificationResponseHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.onesignal.OneSignal.PostNotificationResponseHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPostNotificationResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPostNotificationResponseHandlerInvoker); }
			}

			static Delegate cb_onFailure_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onFailure_Lorg_json_JSONObject_ == null)
					cb_onFailure_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lorg_json_JSONObject_);
				return cb_onFailure_Lorg_json_JSONObject_;
			}

			static void n_OnFailure_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lorg_json_JSONObject_;
			public unsafe void OnFailure (global::Org.Json.JSONObject p0)
			{
				if (id_onFailure_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onFailure_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onFailure_Lorg_json_JSONObject_, __args);
			}

			static Delegate cb_onSuccess_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lorg_json_JSONObject_Handler ()
			{
				if (cb_onSuccess_Lorg_json_JSONObject_ == null)
					cb_onSuccess_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lorg_json_JSONObject_);
				return cb_onSuccess_Lorg_json_JSONObject_;
			}

			static void n_OnSuccess_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lorg_json_JSONObject_;
			public unsafe void OnSuccess (global::Org.Json.JSONObject p0)
			{
				if (id_onSuccess_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_onSuccess_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lorg/json/JSONObject;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSuccess_Lorg_json_JSONObject_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/onesignal/OneSignal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OneSignal); }
		}

		protected OneSignal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/constructor[@name='OneSignal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OneSignal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OneSignal)) {
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

		static IntPtr id_deleteTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteTag", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteTag (string p0)
		{
			if (id_deleteTag_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteTag_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteTag_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_deleteTags_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteTags", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteTags (string p0)
		{
			if (id_deleteTags_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteTags_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteTags", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteTags_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_deleteTags_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='deleteTags' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("deleteTags", "(Ljava/util/Collection;)V", "")]
		public static unsafe void DeleteTags (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_deleteTags_Ljava_util_Collection_ == IntPtr.Zero)
				id_deleteTags_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "deleteTags", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteTags_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_enableInAppAlertNotification_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='enableInAppAlertNotification' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableInAppAlertNotification", "(Z)V", "")]
		public static unsafe void EnableInAppAlertNotification (bool p0)
		{
			if (id_enableInAppAlertNotification_Z == IntPtr.Zero)
				id_enableInAppAlertNotification_Z = JNIEnv.GetStaticMethodID (class_ref, "enableInAppAlertNotification", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableInAppAlertNotification_Z, __args);
			} finally {
			}
		}

		static IntPtr id_enableNotificationsWhenActive_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='enableNotificationsWhenActive' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableNotificationsWhenActive", "(Z)V", "")]
		public static unsafe void EnableNotificationsWhenActive (bool p0)
		{
			if (id_enableNotificationsWhenActive_Z == IntPtr.Zero)
				id_enableNotificationsWhenActive_Z = JNIEnv.GetStaticMethodID (class_ref, "enableNotificationsWhenActive", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableNotificationsWhenActive_Z, __args);
			} finally {
			}
		}

		static IntPtr id_enableSound_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='enableSound' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableSound", "(Z)V", "")]
		public static unsafe void EnableSound (bool p0)
		{
			if (id_enableSound_Z == IntPtr.Zero)
				id_enableSound_Z = JNIEnv.GetStaticMethodID (class_ref, "enableSound", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableSound_Z, __args);
			} finally {
			}
		}

		static IntPtr id_enableVibrate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='enableVibrate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableVibrate", "(Z)V", "")]
		public static unsafe void EnableVibrate (bool p0)
		{
			if (id_enableVibrate_Z == IntPtr.Zero)
				id_enableVibrate_Z = JNIEnv.GetStaticMethodID (class_ref, "enableVibrate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableVibrate_Z, __args);
			} finally {
			}
		}

		static IntPtr id_getTags_Lcom_onesignal_OneSignal_GetTagsHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='getTags' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.GetTagsHandler']]"
		[Register ("getTags", "(Lcom/onesignal/OneSignal$GetTagsHandler;)V", "")]
		public static unsafe void GetTags (global::Com.OneSignal.Android.OneSignal.IGetTagsHandler p0)
		{
			if (id_getTags_Lcom_onesignal_OneSignal_GetTagsHandler_ == IntPtr.Zero)
				id_getTags_Lcom_onesignal_OneSignal_GetTagsHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getTags", "(Lcom/onesignal/OneSignal$GetTagsHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getTags_Lcom_onesignal_OneSignal_GetTagsHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_handleNotificationOpened_Landroid_content_Context_Lorg_json_JSONArray_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='handleNotificationOpened' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='boolean']]"
		[Register ("handleNotificationOpened", "(Landroid/content/Context;Lorg/json/JSONArray;Z)V", "")]
		public static unsafe void HandleNotificationOpened (global::Android.Content.Context p0, global::Org.Json.JSONArray p1, bool p2)
		{
			if (id_handleNotificationOpened_Landroid_content_Context_Lorg_json_JSONArray_Z == IntPtr.Zero)
				id_handleNotificationOpened_Landroid_content_Context_Lorg_json_JSONArray_Z = JNIEnv.GetStaticMethodID (class_ref, "handleNotificationOpened", "(Landroid/content/Context;Lorg/json/JSONArray;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handleNotificationOpened_Landroid_content_Context_Lorg_json_JSONArray_Z, __args);
			} finally {
			}
		}

		static IntPtr id_idsAvailable_Lcom_onesignal_OneSignal_IdsAvailableHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='idsAvailable' and count(parameter)=1 and parameter[1][@type='com.onesignal.OneSignal.IdsAvailableHandler']]"
		[Register ("idsAvailable", "(Lcom/onesignal/OneSignal$IdsAvailableHandler;)V", "")]
		public static unsafe void IdsAvailable (global::Com.OneSignal.Android.OneSignal.IIdsAvailableHandler p0)
		{
			if (id_idsAvailable_Lcom_onesignal_OneSignal_IdsAvailableHandler_ == IntPtr.Zero)
				id_idsAvailable_Lcom_onesignal_OneSignal_IdsAvailableHandler_ = JNIEnv.GetStaticMethodID (class_ref, "idsAvailable", "(Lcom/onesignal/OneSignal$IdsAvailableHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idsAvailable_Lcom_onesignal_OneSignal_IdsAvailableHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_onesignal_OneSignal_NotificationOpenedHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='init' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.onesignal.OneSignal.NotificationOpenedHandler']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$NotificationOpenedHandler;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0, string p1, string p2, global::Com.OneSignal.Android.OneSignal.INotificationOpenedHandler p3)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_onesignal_OneSignal_NotificationOpenedHandler_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/onesignal/OneSignal$NotificationOpenedHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_onesignal_OneSignal_NotificationOpenedHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_onPaused;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='onPaused' and count(parameter)=0]"
		[Register ("onPaused", "()V", "")]
		public static unsafe void OnPaused ()
		{
			if (id_onPaused == IntPtr.Zero)
				id_onPaused = JNIEnv.GetStaticMethodID (class_ref, "onPaused", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onPaused);
			} finally {
			}
		}

		static IntPtr id_onResumed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='onResumed' and count(parameter)=0]"
		[Register ("onResumed", "()V", "")]
		public static unsafe void OnResumed ()
		{
			if (id_onResumed == IntPtr.Zero)
				id_onResumed = JNIEnv.GetStaticMethodID (class_ref, "onResumed", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResumed);
			} finally {
			}
		}

		static IntPtr id_postNotification_Ljava_lang_String_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='postNotification' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.onesignal.OneSignal.PostNotificationResponseHandler']]"
		[Register ("postNotification", "(Ljava/lang/String;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V", "")]
		public static unsafe void PostNotification (string p0, global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler p1)
		{
			if (id_postNotification_Ljava_lang_String_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_ == IntPtr.Zero)
				id_postNotification_Ljava_lang_String_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_ = JNIEnv.GetStaticMethodID (class_ref, "postNotification", "(Ljava/lang/String;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postNotification_Ljava_lang_String_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_postNotification_Lorg_json_JSONObject_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='postNotification' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.onesignal.OneSignal.PostNotificationResponseHandler']]"
		[Register ("postNotification", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V", "")]
		public static unsafe void PostNotification (global::Org.Json.JSONObject p0, global::Com.OneSignal.Android.OneSignal.IPostNotificationResponseHandler p1)
		{
			if (id_postNotification_Lorg_json_JSONObject_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_ == IntPtr.Zero)
				id_postNotification_Lorg_json_JSONObject_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_ = JNIEnv.GetStaticMethodID (class_ref, "postNotification", "(Lorg/json/JSONObject;Lcom/onesignal/OneSignal$PostNotificationResponseHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_postNotification_Lorg_json_JSONObject_Lcom_onesignal_OneSignal_PostNotificationResponseHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_promptLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='promptLocation' and count(parameter)=0]"
		[Register ("promptLocation", "()V", "")]
		public static unsafe void PromptLocation ()
		{
			if (id_promptLocation == IntPtr.Zero)
				id_promptLocation = JNIEnv.GetStaticMethodID (class_ref, "promptLocation", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_promptLocation);
			} finally {
			}
		}

		static IntPtr id_removeNotificationOpenedHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='removeNotificationOpenedHandler' and count(parameter)=0]"
		[Register ("removeNotificationOpenedHandler", "()V", "")]
		public static unsafe void RemoveNotificationOpenedHandler ()
		{
			if (id_removeNotificationOpenedHandler == IntPtr.Zero)
				id_removeNotificationOpenedHandler = JNIEnv.GetStaticMethodID (class_ref, "removeNotificationOpenedHandler", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeNotificationOpenedHandler);
			} finally {
			}
		}

		static IntPtr id_sendTag_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendTag", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendTag (string p0, string p1)
		{
			if (id_sendTag_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTag_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendTag", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendTag_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendTags_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendTags", "(Ljava/lang/String;)V", "")]
		public static unsafe void SendTags (string p0)
		{
			if (id_sendTags_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTags_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendTags", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendTags_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sendTags_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='sendTags' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("sendTags", "(Lorg/json/JSONObject;)V", "")]
		public static unsafe void SendTags (global::Org.Json.JSONObject p0)
		{
			if (id_sendTags_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_sendTags_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "sendTags", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendTags_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogLevel_Lcom_onesignal_OneSignal_LOG_LEVEL_Lcom_onesignal_OneSignal_LOG_LEVEL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='com.onesignal.OneSignal.LOG_LEVEL'] and parameter[2][@type='com.onesignal.OneSignal.LOG_LEVEL']]"
		[Register ("setLogLevel", "(Lcom/onesignal/OneSignal$LOG_LEVEL;Lcom/onesignal/OneSignal$LOG_LEVEL;)V", "")]
		public static unsafe void SetLogLevel (global::Com.OneSignal.Android.OneSignal.LOG_LEVEL p0, global::Com.OneSignal.Android.OneSignal.LOG_LEVEL p1)
		{
			if (id_setLogLevel_Lcom_onesignal_OneSignal_LOG_LEVEL_Lcom_onesignal_OneSignal_LOG_LEVEL_ == IntPtr.Zero)
				id_setLogLevel_Lcom_onesignal_OneSignal_LOG_LEVEL_Lcom_onesignal_OneSignal_LOG_LEVEL_ = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(Lcom/onesignal/OneSignal$LOG_LEVEL;Lcom/onesignal/OneSignal$LOG_LEVEL;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_Lcom_onesignal_OneSignal_LOG_LEVEL_Lcom_onesignal_OneSignal_LOG_LEVEL_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogLevel_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setLogLevel", "(II)V", "")]
		public static unsafe void SetLogLevel (int p0, int p1)
		{
			if (id_setLogLevel_II == IntPtr.Zero)
				id_setLogLevel_II = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_II, __args);
			} finally {
			}
		}

		static IntPtr id_setSubscription_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='setSubscription' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSubscription", "(Z)V", "")]
		public static unsafe void SetSubscription (bool p0)
		{
			if (id_setSubscription_Z == IntPtr.Zero)
				id_setSubscription_Z = JNIEnv.GetStaticMethodID (class_ref, "setSubscription", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSubscription_Z, __args);
			} finally {
			}
		}

		static IntPtr id_startInit_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.onesignal']/class[@name='OneSignal']/method[@name='startInit' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startInit", "(Landroid/content/Context;)Lcom/onesignal/OneSignal$Builder;", "")]
		public static unsafe global::Com.OneSignal.Android.OneSignal.Builder StartInit (global::Android.Content.Context p0)
		{
			if (id_startInit_Landroid_content_Context_ == IntPtr.Zero)
				id_startInit_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startInit", "(Landroid/content/Context;)Lcom/onesignal/OneSignal$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.OneSignal.Android.OneSignal.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.OneSignal.Android.OneSignal.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_startInit_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
