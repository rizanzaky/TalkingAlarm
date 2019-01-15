using UIKit;

namespace TalkingAlarm.Views.Alarms.AlarmList
{
    public class AlarmsTableView : UITableView
    {
        public AlarmsTableView()
        {
            TranslatesAutoresizingMaskIntoConstraints = false;
        }

        public sealed override bool TranslatesAutoresizingMaskIntoConstraints { get; set; }
    }
}