using System.Collections.Generic;

namespace MinBody.Models
{
    public class TherapistSchedule
    {
        public TherapistSchedule()
        {
            Schedule = new List<TimeInterval>();
            BreakSchedule = new List<TimeInterval>();
        }

        public Therapist Therapist { get; set; }

        public List<TimeInterval> Schedule { get; private set; }

        public List<TimeInterval> BreakSchedule { get; private set; } 
    }
}
