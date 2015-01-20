using System;

namespace MinBody.Models
{
    public class ScheduleAppointment
    {
        public int Id { get; set; }

        public int RoomId { get { return Room != null ? Room.Id : -1; } }

        public Room Room { get; set; }

        public int TherapistId { get { return Therapist != null ? Therapist.Id : -1; } }

        public Therapist Therapist { get; set; }

        public int ClientId
        {
            get { return Client != null ? Client.Id : -1; }
        }

        public Customer Client { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StopDate { get; set; }

        public string Type { get; set; }

        public int LocationId { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }

        public string SessionType { get; set; }

        public string UpgradeType { get; set; }

        public int SessionTime { get; set; }

        public string Upgrades { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsCharged { get; set; }

        public int BookedById { get; set; }

        public bool IsCouple { get; set; }

        public bool IsAllDay { get; set; }

        public string ReccurenceInfo { get; set; }

        public bool IsTherapistRequired { get; set; }
    }
}
