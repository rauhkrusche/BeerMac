using System;

using AppKit;
using Foundation;
using DerAtrox.BeerNET;

namespace BeerMac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void encodeClick(NSObject sender)
        {
            var b = new BeerEx();
            outputTextOutlet.StringValue = b.Encode(inputTextOutlet.StringValue);
        }

        partial void decodeClick(NSObject sender)
        {
            var b = new BeerEx();
            inputTextOutlet.StringValue = b.Decode(outputTextOutlet.StringValue);
        }
    }
}
