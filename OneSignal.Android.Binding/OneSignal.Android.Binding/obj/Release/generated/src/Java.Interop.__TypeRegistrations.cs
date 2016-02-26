using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/onesignal",
					},
					new Converter<string, Type>[]{
						lookup_com_onesignal_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_onesignal_mappings;
		static Type lookup_com_onesignal_package (string klass)
		{
			if (package_com_onesignal_mappings == null) {
				package_com_onesignal_mappings = new string[]{
					"com/onesignal/BackgroundBroadcaster:Com.OneSignal.Android.BackgroundBroadcaster",
					"com/onesignal/BuildConfig:Com.OneSignal.Android.BuildConfig",
					"com/onesignal/NotificationBundleProcessor:Com.OneSignal.Android.NotificationBundleProcessor",
					"com/onesignal/NotificationOpenedActivity:Com.OneSignal.Android.NotificationOpenedActivity",
					"com/onesignal/NotificationOpenedProcessor:Com.OneSignal.Android.NotificationOpenedProcessor",
					"com/onesignal/NotificationOpenedReceiver:Com.OneSignal.Android.NotificationOpenedReceiver",
					"com/onesignal/OneSignal:Com.OneSignal.Android.OneSignal",
					"com/onesignal/OneSignal$Builder:Com.OneSignal.Android.OneSignal/Builder",
					"com/onesignal/OneSignal$LOG_LEVEL:Com.OneSignal.Android.OneSignal/LOG_LEVEL",
					"com/onesignal/OneSignalDbHelper:Com.OneSignal.Android.OneSignalDbHelper",
					"com/onesignal/PermissionsActivity:Com.OneSignal.Android.PermissionsActivity",
					"com/onesignal/PushRegistratorADM:Com.OneSignal.Android.PushRegistratorADM",
					"com/onesignal/PushRegistratorGPS:Com.OneSignal.Android.PushRegistratorGPS",
					"com/onesignal/SyncService:Com.OneSignal.Android.SyncService",
				};
			}

			return Lookup (package_com_onesignal_mappings, klass);
		}
	}
}
