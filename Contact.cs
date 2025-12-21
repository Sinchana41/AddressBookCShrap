namespace AddressBookSystems
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
            if (obj == null || !(obj is Contact))
                return false;

            Contact other = (Contact)obj;

            return this.FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && this.LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                FirstName.ToLower(),
                LastName.ToLower()
            );
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}, {Zip}, {Phone}, {Email}";
        }
    }
}