using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TalkingAlarm.Views.Alarms.AlarmList
{
    public class AlarmsTableSource : UITableViewSource
    {
        public List<string> DataSource { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "AlarmsTableCell");
            cell.TextLabel.Text = DataSource[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return DataSource.Count;
        }
    }
}