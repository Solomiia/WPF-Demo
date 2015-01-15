using System;
using System.Collections.ObjectModel;
using MinBody.Models;
using MinBody.ViewModels.Base;

namespace MinBody.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _items = new ObservableCollection<object>()
            {
               new ViewModel() {DisplayName = "Item1"},
               new ViewModel() {DisplayName = "Item2"},
               new DocumentViewModel() {DisplayName = "Appointments", Image = @"E:\development\wpf\MinBody\MinBody\Content\appointment.png"},
               new DocumentViewModel() {DisplayName = "Persons", Image = @"E:\development\wpf\MinBody\MinBody\Content\icon-person.png"}
            };
       
        }


        private ObservableCollection<object> _items;
        private ObservableCollection<AppointmentViewModel> _appointments;

        public ObservableCollection<object> Items
        {
            get { return _items; }
            private set { SetProperty(ref _items, value, "Items"); }

        }

        public ObservableCollection<AppointmentViewModel> Appointments {
            get { return _appointments; }
            private set { SetProperty(ref _appointments, value, "Appointments"); }
        }
    }
}
