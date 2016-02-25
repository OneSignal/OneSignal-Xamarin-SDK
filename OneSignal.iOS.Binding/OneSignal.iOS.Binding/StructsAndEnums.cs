using System;
using ObjCRuntime;

namespace Com.OneSignal.iOS
{
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
}