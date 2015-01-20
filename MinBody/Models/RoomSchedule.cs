using System;
using System.Collections.Generic;
using System.Linq;

namespace MinBody.Models
{
    public class RoomSchedule
    {
        public RoomSchedule()
        {
            Therapists = new List<TherapistSchedule>();
        }

        public Room Room { get; set; }

        public List<TherapistSchedule> Therapists { get; set; }

        public string FullName
        {
            get
            {
                return Room == null
                    ? string.Empty
                    : string.Format("{0} ({1})", Room.Name, String.Join(", ", Therapists.Select(x => x.Therapist.Name.Replace(",", ""))));
            }
        }

        public int Id
        {
            get { return Room != null ? Room.Id : -1; }
        }
    }
}
