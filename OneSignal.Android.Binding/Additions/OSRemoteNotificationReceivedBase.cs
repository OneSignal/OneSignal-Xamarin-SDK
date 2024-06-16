using Android.Content;

namespace Com.OneSignal.Android
{
    public abstract class OSRemoteNotificationReceivedBase : Java.Lang.Object, OneSignal.IOSRemoteNotificationReceivedHandler
    {
        public abstract void RemoteNotificationReceived(Context ctx, OSNotificationReceivedEvent ev);
    }
}
