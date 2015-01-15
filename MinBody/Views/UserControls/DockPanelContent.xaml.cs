using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Mvvm;
using DevExpress.Xpf.Docking.VisualElements;

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
        }

        public ICommand DockLayoutDelegateCommand { get; set; }

        public ICommand SettingsPanelDelegateCommand { get; set; }

        public void DockLayoutManagerCommand()
        {
            DockLayoutManager.DockController.Activate(SettingsPanel);
        }

        public void SettingsPanelCommand(object sender, StylusDownEventArgs e)
        {
         //   e.StylusDevice.Captured.
        }

        
    }
}
