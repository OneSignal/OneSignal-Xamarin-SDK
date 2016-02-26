using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.App {

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.app']/interface[@name='OnActivityPausedListener']"
	[Register ("android/app/OnActivityPausedListener", "", "Android.App.IOnActivityPausedListenerInvoker")]
	public partial interface IOnActivityPausedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.app']/interface[@name='OnActivityPausedListener']/method[@name='onPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPaused", "(Landroid/app/Activity;)V", "GetOnPaused_Landroid_app_Activity_Handler:Android.App.IOnActivityPausedListenerInvoker, OneSignal.Android.Binding")]
		void OnPaused (global::Android.App.Activity p0);

	}

	[global::Android.Runtime.Register ("android/app/OnActivityPausedListener", DoNotGenerateAcw=true)]
	internal class IOnActivityPausedListenerInvoker : global::Java.Lang.Object, IOnActivityPausedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/app/OnActivityPausedListener");
		IntPtr class_ref;

		public static IOnActivityPausedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnActivityPausedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.app.OnActivityPausedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnActivityPausedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnActivityPausedListenerInvoker); }
		}

		static Delegate cb_onPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onPaused_Landroid_app_Activity_ == null)
				cb_onPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPaused_Landroid_app_Activity_);
			return cb_onPaused_Landroid_app_Activity_;
		}

		static void n_OnPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.App.IOnActivityPausedListener __this = global::Java.Lang.Object.GetObject<global::Android.App.IOnActivityPausedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPaused (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPaused_Landroid_app_Activity_;
		public unsafe void OnPaused (global::Android.App.Activity p0)
		{
			if (id_onPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_onPaused_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onPaused", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onPaused_Landroid_app_Activity_, __args);
		}

	}

	public partial class ActivityPausedEventArgs : global::System.EventArgs {

		public ActivityPausedEventArgs (global::Android.App.Activity p0)
		{
			this.p0 = p0;
		}

		global::Android.App.Activity p0;
		public global::Android.App.Activity P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/android/app/OnActivityPausedListenerImplementor")]
	internal sealed partial class IOnActivityPausedListenerImplementor : global::Java.Lang.Object, IOnActivityPausedListener {

		object sender;

		public IOnActivityPausedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/app/OnActivityPausedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ActivityPausedEventArgs> Handler;
#pragma warning restore 0649

		public void OnPaused (global::Android.App.Activity p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ActivityPausedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnActivityPausedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
