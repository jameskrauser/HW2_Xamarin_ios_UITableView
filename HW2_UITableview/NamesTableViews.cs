using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace HW2_UITableview
{
    public class NamesTableViews: UITableViewSource
    {
        private List<string> names;
        /*
        public NamesTableViews()
        {
        }
        */
        public NamesTableViews(List<string> names)
        {
            this.names = names;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // throw new NotImplementedException(); 
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = names[indexPath.Row];
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            //throw new NotImplementedException();
            return names.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);
            var selectedName = names[indexPath.Row];

            Console.WriteLine("selectedName= {0} ", selectedName); 

        }
    }
}
