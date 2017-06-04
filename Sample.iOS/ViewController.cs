using System;

using UIKit;

namespace Sample.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Console.WriteLine("-> ViewDidLoad");
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            Console.WriteLine("-> ViewWillAppear");
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			Console.WriteLine("-> ViewDidAppear");
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            Console.WriteLine("-> ViewWillDisappear");
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            Console.WriteLine("-> ViewDidDisappear");
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();

            Console.WriteLine("-> ViewDidUnload");
        }
    }
}