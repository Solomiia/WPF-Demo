using System;

namespace MinBody.Models
{
    public class TimeInterval
    {
        public TimeInterval() { }

        public TimeInterval(DateTime startDateTime, DateTime endDateTime)
        {
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public TimeInterval(int id, DateTime startDateTime, DateTime endDateTime)
        {
            Id = id;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }

        public int Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
    }
}
