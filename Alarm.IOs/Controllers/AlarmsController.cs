using System.Collections.Generic;
using TalkingAlarm.Views.Alarms;
using TalkingAlarm.Views.Alarms.AlarmList;
using UIKit;

namespace TalkingAlarm.Controllers
{
    public class AlarmsController : UIViewController
    {
        private readonly AlarmsView _alarmsView;
        private readonly AlarmsTableSource _alarmsTableSource;

        //public AlarmsController(AlarmsView alarmsView, AlarmsTableSource alarmsTableSource)
        public AlarmsController()
        {
            _alarmsView = new AlarmsView(); //alarmsView;
            _alarmsTableSource = new AlarmsTableSource(); //alarmsTableSource;
        }

        public override void LoadView()
        {
            View = _alarmsView;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            NavigationItem.Title = "Alarms";

            _alarmsView.AlarmsTableView.Source = _alarmsTableSource;

            _alarmsTableSource.DataSource = new List<string>{ "04:20 AM", "05:05 AM", "05:30 AM", "06:00 AM", "07:30 AM", "05:15 PM" };
        }
    }
}