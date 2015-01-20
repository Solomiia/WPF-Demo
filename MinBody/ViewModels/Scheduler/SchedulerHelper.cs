using System.Collections.Generic;
using System.Collections.ObjectModel;
using MinBody.Models;
using MinBody.ViewModels.Base;

namespace MinBody.ViewModels.Scheduler
{
    public class SchedulerHelper : ViewModelBase
    {
        public SchedulerHelper()
        {

            _rooms = new ObservableCollection<RoomSchedule>()
            {
                new RoomSchedule() { Room = new Room() { Id = 1, Name = "Room1"}, Therapists = new List<TherapistSchedule>()
                {
                   new TherapistSchedule() {Therapist = new Therapist()
                   {
                       Id = 1,
                       Name="Alex"
                   }}
                }},
                new RoomSchedule() { Room = new Room() { Id = 2, Name = "Room2"}, Therapists = new List<TherapistSchedule>()
                {
                   new TherapistSchedule() {Therapist = new Therapist()
                   {
                       Id = 2,
                       Name="Solomiia"
                   }}
                }},
                new RoomSchedule() { Room = new Room() { Id = 3, Name = "Room3"}, Therapists = new List<TherapistSchedule>()
                {
                   new TherapistSchedule() {Therapist = new Therapist()
                   {
                       Id = 3,
                       Name="Vova"
                   }}
                }},
            };
        }

        private ObservableCollection<ScheduleAppointment> _appointments;

        public ObservableCollection<ScheduleAppointment> Appointments
        {
            get { return _appointments; }
            private set { SetProperty(ref _appointments, value, "Appointments"); }
        }

        private ObservableCollection<RoomSchedule> _rooms;

        public ObservableCollection<RoomSchedule> Rooms
        {
            get { return _rooms; }
            private set { SetProperty(ref _rooms, value, "Rooms"); }
        }

    }
}
