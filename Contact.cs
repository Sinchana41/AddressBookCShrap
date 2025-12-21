namespace AddressBookSystem.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Contact other)
                return FirstName.Equals(other.FirstName);
            return false;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}";
        }
    }
}
