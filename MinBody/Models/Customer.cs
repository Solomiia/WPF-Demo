namespace MinBody.Models
{
    public class Customer
    {
        public Customer()
        {
            Id = -1;
        }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Street { get; set; }

        public int Zip { get; set; }

        public string City { get; set; }

        public int Miles { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
    }
}
