using Android.Content;
using Com.Huawei.Agconnect.Config;
using System;
using System.IO;

namespace Com.OneSignal.Sample.Droid
{
   public class HmsLazyInputStream : LazyInputStream
    {
        public HmsLazyInputStream(Context context) : base(context)
        {
        }

        public override Stream Get(Context context)
        {
            try
            {
               Console.WriteLine("Trying to read agconnect-services.json file");
               return context.Assets.Open("agconnect-services.json");
            }
            catch (Exception e)
            {
               Console.WriteLine("Failed to read agconnect-services.json file");
               return null;
            }
        }
    }
}
