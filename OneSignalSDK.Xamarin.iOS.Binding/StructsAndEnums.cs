using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Com.OneSignal.iOS {
	[Native]
	public enum OSNotificationActionType : ulong
	{
		Opened,
		ActionTaken
	}

	[Native]
	public enum OneSLogLevel : ulong
	{
		None,
		Fatal,
		Error,
		Warn,
		Info,
		Debug,
		Verbose
	}

	[Native]
	public enum OSNotificationPermission : long
	{
		NotDetermined = 0,
		Denied,
		Authorized,
		Provisional,
		Ephemeral
	}
}