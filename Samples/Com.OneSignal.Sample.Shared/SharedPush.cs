using System;
namespace Com.OneSignal.Sample.Shared
{
    public class SharedPush
    {
        public SharedPush()
        {
            
        }

        public void Register()
        {
            OneSignal.Current.RegisterForPushNotifications();
        }
    }
}
