namespace AutoMapperYt.Models
{
    public class Person
    {
        protected Person() { }

        public Person(int id, string firstName, string lastName, DateTime birthDate, MaritalStatusEnum maritalStatus, string phoneNumber, string fullAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            MaritalStatus = maritalStatus;
            PhoneNumber = phoneNumber;
            FullAddress = fullAddress;

            Active = true;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public MaritalStatusEnum MaritalStatus { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullAddress { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
