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
         OneSignal.Current.SetLogLevel(Abstractions.LOG_LEVEL.VERBOSE, Abstractions.LOG_LEVEL.WARN);
         OneSignal.Current.StartInit("b2f7f966-d8cc-11e4-bed1-df8f05be55ba").EndInit();
        }
    }
}
