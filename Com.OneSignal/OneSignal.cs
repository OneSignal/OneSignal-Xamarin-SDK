using System;
using System.Diagnostics;
using Com.OneSignal.Abstractions;

namespace Com.OneSignal
{
   public class OneSignal
   {
      static readonly Lazy<IOneSignal> Implementation = new Lazy<IOneSignal>(CreateOneSignal);

      public static IOneSignal Current
      {
         get
         {
            if (Implementation.Value == null)
               throw NotImplementedInReferenceAssembly();

            return Implementation.Value;
         }
      }

      static IOneSignal CreateOneSignal()
      {
         #if PORTABLE
            Debug.WriteLine("PORTABLE Reached");
            return null;
         #else
            Debug.WriteLine("Other reached");
            return new OneSignalImplementation();
         #endif
      }

      internal static Exception NotImplementedInReferenceAssembly()
      {
         return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
      }
   }
}
