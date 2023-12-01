using System;
using System.Diagnostics;
using Android.App;
using Android.Content;

namespace Com.OneSignal.Android
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class NotificationExtensionAttribute : Attribute, Java.Interop.IJniNameProviderAttribute
    {
        public string Name { get; set; }
        public NotificationExtensionAttribute()
        {
        }
    }
}
