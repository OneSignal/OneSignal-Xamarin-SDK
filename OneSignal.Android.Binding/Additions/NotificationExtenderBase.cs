using AndroidX.Core.App;

namespace Com.OneSignal.Android
{
    public abstract class NotificationExtenderBase : Java.Lang.Object, NotificationCompat.IExtender
    {
        public abstract NotificationCompat.Builder Extend(NotificationCompat.Builder builder);
    }
}
