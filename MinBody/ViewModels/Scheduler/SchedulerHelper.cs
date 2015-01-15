using System.Collections.ObjectModel;
using MinBody.Models;
using MinBody.ViewModels.Base;

namespace MinBody.ViewModels.Scheduler
{
    public class SchedulerHelper: ViewModelBase
    {
        public SchedulerHelper()
        {
       
            _people = new ObservableCollection<PeopleViewModel>()
            {
                new PeopleViewModel() { Id = 1, Name = "Alex"},
                new PeopleViewModel() {Id = 2, Name = "Solomiia"},
                new PeopleViewModel() {Id = 3, Name = "Vova"}
            };
        }

        private ObservableCollection<AppointmentViewModel> _appointments;

        public ObservableCollection<AppointmentViewModel> Appointments
        {
            get { return _appointments; }
            private set { SetProperty(ref _appointments, value, "Appointments"); }
        }

        private ObservableCollection<PeopleViewModel> _people;

        public ObservableCollection<PeopleViewModel> People
        {
            get { return _people; }
            private set { SetProperty(ref _people, value, "People"); }
        }
        
    }
}
