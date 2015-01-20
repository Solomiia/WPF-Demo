using System;

namespace MinBody.Models
{
    public class ScheduleResourse
    {
        public int Id { get; set; }

        public int TherapistId { get; set; }

        public string TherapistName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StopDate { get; set; }

        public DateTime BreakStartTime { get; set; }

        public DateTime BreakStopTime { get; set; }

        public string Type { get; set; }

        public int LocationId { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
