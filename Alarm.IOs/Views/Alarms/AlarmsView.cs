using TalkingAlarm.Utilities;
using TalkingAlarm.Views.Alarms.AlarmList;
using UIKit;

namespace TalkingAlarm.Views.Alarms
{
    public class AlarmsView : UIView
    {
        public AlarmsTableView AlarmsTableView { get; set; }

        public AlarmsView()
        {
            BuildView();
        }

        private void BuildView()
        {
            CreateElements();
            StyleElements();
            AddElements();
            LayoutElements();
        }

        private void CreateElements()
        {
            AlarmsTableView = new AlarmsTableView();
        }

        private void StyleElements()
        {
            BackgroundColor = UIColor.Blue;
        }

        private void AddElements()
        {
            Add(AlarmsTableView);
        }

        private void LayoutElements()
        {
            AlarmsTableView.AlignTopAnchor(TopAnchor, 20f);
            AlarmsTableView.AlignLeftAnchor(LeftAnchor, 10f);
            AlarmsTableView.AlignRightAnchor(RightAnchor, 10f);
            AlarmsTableView.AlignBottomAnchor(BottomAnchor, 20f);
        }
    }
}