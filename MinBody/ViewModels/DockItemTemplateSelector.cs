using System.Windows;
using System.Windows.Controls;

namespace MinBody.ViewModels
{
    public class DockItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LayoutPanelTemplate { get; set; }
        public DataTemplate DocumentPanelTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return item is DocumentViewModel ? DocumentPanelTemplate : LayoutPanelTemplate;
        }
    }
}
