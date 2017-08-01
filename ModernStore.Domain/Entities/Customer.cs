using System;

namespace ModernStore.Domain.Entities
{
    public class Customer
    {
        public Customer(string firstName, string lastName, DateTime? birthDate, string password, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Active = false;
            UserName = email;
            Password = password;
            Email = email;

            //Validações

        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public bool Active { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }


        public void Activate()
        {
            Active = true;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
