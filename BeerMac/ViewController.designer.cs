// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace BeerMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton decodeButtonOutlet { get; set; }

		[Outlet]
		AppKit.NSButton encodeButtonOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField inputTextOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField outputTextOutlet { get; set; }

		[Action ("decodeClick:")]
		partial void decodeClick (Foundation.NSObject sender);

		[Action ("encodeClick:")]
		partial void encodeClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (inputTextOutlet != null) {
				inputTextOutlet.Dispose ();
				inputTextOutlet = null;
			}

			if (outputTextOutlet != null) {
				outputTextOutlet.Dispose ();
				outputTextOutlet = null;
			}

			if (encodeButtonOutlet != null) {
				encodeButtonOutlet.Dispose ();
				encodeButtonOutlet = null;
			}

			if (decodeButtonOutlet != null) {
				decodeButtonOutlet.Dispose ();
				decodeButtonOutlet = null;
			}
		}
	}
}
