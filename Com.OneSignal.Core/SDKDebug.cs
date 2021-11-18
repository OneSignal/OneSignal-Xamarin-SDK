using System;

namespace Com.OneSignal.Core {

    //TODO: Finish Log
    public class SDKDebug {
        public static event Action<object> LogIntercept;
        public static event Action<object> WarnIntercept;
        public static event Action<object> ErrorIntercept;

        public static void Log(string message) {
            if (LogIntercept != null)
                LogIntercept(message);
        }

        public static void Warn(string message) {
            if (WarnIntercept != null)
                WarnIntercept(message);
        }

        public static void Error(string message) {
            if (ErrorIntercept != null)
                ErrorIntercept(message);
        }

        private static string _formatMessage(string message) => "[OneSignal] " + message;
    }
}
