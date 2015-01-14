using System.Collections.ObjectModel;

namespace MinBody.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _Items = new ObservableCollection<object>()
            {
               new ViewModel() {DisplayName = "Item1"},
               new ViewModel() {DisplayName = "Item2"},
               new DocumentViewModel() {DisplayName = "Document1"},
               new DocumentViewModel() {DisplayName = "Document2"}
            };
        }


        private ObservableCollection<object> _Items;

        public ObservableCollection<object> Items
        {
            get { return _Items; }
            private set { SetProperty(ref _Items, value, "Items"); }

        }
    }
}
