using System;
namespace Com.OneSignal
{
    public class IdsAvailableHandler : Java.Lang.Object, Android.OneSignal.IIdsAvailableHandler
    {
        public void IdsAvailable(string p0, string p1)
        {
            (OneSignal.Current as OneSignalImplementation).onIdsAvailable(p0, p1);
        }
    }
}
