using System.Windows.Controls;
using MinBody.ViewModels.Scheduler;

namespace MinBody.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SchedulerUserControl.xaml
    /// </summary>
    public partial class SchedulerUserControl : UserControl
    {
        public SchedulerUserControl()
        {
            InitializeComponent();
            DataContext = new SchedulerHelper();
        }

     
    }
}
