using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Scheduler;

namespace MinBody.ExtendedControls
{
    public class ExtendedDateNavidator : DateNavigator
    {
        public new SchedulerControl SchedulerControl
        {
            get { return null; }
            set { }
        }
    }
}