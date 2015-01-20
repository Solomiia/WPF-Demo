using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace MinBody.Views.UserControls
{
    /// <summary>
    /// Interaction logic for DockPanelContent.xaml
    /// </summary>
    public partial class DockPanelContent : UserControl
    {
        public DockPanelContent()
        {
            InitializeComponent();
            DataContext = this;
            DockLayoutDelegateCommand = new DelegateCommand(DockLayoutManagerCommand);
            Loaded += MergeNavigationScheduler;
        }

        private void MergeNavigationScheduler(object sender, RoutedEventArgs e)
        {
//           UserControlSettingsPanel.DateNavigator.
//            SchedulerUserControl.ScheduleControl.;
        }

        public ICommand DockLayoutDelegateCommand { get; set; }

        public ICommand SettingsPanelDelegateCommand { get; set; }

        public void DockLayoutManagerCommand()
        {
            DockLayoutManager.DockController.Activate(SettingsPanel);
        }


    }
}
