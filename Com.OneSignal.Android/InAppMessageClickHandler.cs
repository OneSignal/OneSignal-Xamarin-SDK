using Com.OneSignal.Abstractions;

namespace Com.OneSignal
{
   public class InAppMessageClickHandler : Java.Lang.Object, Android.OneSignal.IInAppMessageClickHandler
    {
        public void InAppMessageClicked(Android.OSInAppMessageAction action)
        {
            (OneSignal.Current as OneSignalImplementation).OnInAppMessageClicked(OSInAppMessageClickedActionToNative(action));
        }

        private static OSInAppMessageAction OSInAppMessageClickedActionToNative(Android.OSInAppMessageAction action)
        {
            OSInAppMessageAction inAppMessageAction = new OSInAppMessageAction();
            inAppMessageAction.clickName = action.ClickName;
            inAppMessageAction.clickUrl = action.ClickUrl;
            inAppMessageAction.firstClick = action.FirstClick;
            inAppMessageAction.closesMessage = action.ClosesMessage;
            return inAppMessageAction;
        }
    }
}
