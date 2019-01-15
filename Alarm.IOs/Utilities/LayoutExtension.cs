using System;
using UIKit;

namespace TalkingAlarm.Utilities
{
    public static class LayoutExtension
    {
        public static NSLayoutConstraint AlignLeftAnchor(this UIView view, NSLayoutXAxisAnchor anchor, nfloat constant)
        {
            var constraint = view.LeftAnchor.ConstraintEqualTo(anchor, constant);
            constraint.Active = true;
            return constraint;
        }

        public static NSLayoutConstraint AlignRightAnchor(this UIView view, NSLayoutXAxisAnchor anchor, nfloat constant)
        {
            var constraint = view.RightAnchor.ConstraintEqualTo(anchor, -constant);
            constraint.Active = true;
            return constraint;
        }

        public static NSLayoutConstraint AlignTopAnchor(this UIView view, NSLayoutYAxisAnchor anchor, nfloat constant)
        {
            var constraint = view.TopAnchor.ConstraintEqualTo(anchor, constant);
            constraint.Active = true;
            return constraint;
        }

        public static NSLayoutConstraint AlignBottomAnchor(this UIView view, NSLayoutYAxisAnchor anchor, nfloat constant)
        {
            var constraint = view.BottomAnchor.ConstraintEqualTo(anchor, -constant);
            constraint.Active = true;
            return constraint;
        }
    }
}