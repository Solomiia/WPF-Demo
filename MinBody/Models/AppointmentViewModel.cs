using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBody.Models
{
    public class AppointmentViewModel
    {
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public String Subject { get; set; }

        public String Description { get; set; }

        public String Location { get; set; }

        public String AllDay { get; set; }

        public String Label { get; set; }

        public String Status { get; set; }

        public String EventType { get; set; }

        public String RecurrenceInfo { get; set; }

        public String ReminderInfo { get; set; }

        public String SchedulerId { get; set; }

    }
}
