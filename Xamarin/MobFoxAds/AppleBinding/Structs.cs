using System.Runtime.InteropServices;
using Foundation;

namespace MobFoxSDKCore
{
	static class CFunctions
	{
		// extern NSString * WebViewJavascriptBridge_js ();
		[DllImport ("__Internal")]
		//@@@[Verify (PlatformInvoke)]
		static extern NSString WebViewJavascriptBridge_js ();
	}
}
