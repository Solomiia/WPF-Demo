namespace MinBody.Models
{
    public class Therapist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string MassageType { get; set; }

        public int RoomId { get; set; }
    }
}
