using System;
using System.Collections.Generic;
using UIKit;

namespace HW2_UITableview
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            List<string> names = new List<string>
            {  "1","2","3","4","5",
                "6","7","8","9","10",
                "10","11","12","13","14"
            };
            NamesTableView.Source =
                              new NamesTableViews(names);



        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
