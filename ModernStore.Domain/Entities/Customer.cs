using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using FluentValidator;
using ModernStore.Shared.Entities;

namespace ModernStore.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(
            string firstName,
            string lastName,
            string email,
            User user)
        {
           FirstName = firstName;
            LastName = lastName;
            BirthDate = null;
            Email = email;
            
            

            //Validações

            new ValidationContract<Customer>(this)
                .IsRequired(x => x.FirstName, "Nome é obrigatório")
                .HasMaxLenght(x => x.FirstName, 60)
                .HasMinLenght(x => x.FirstName, 3, "Tamanho mínimo 3 caracteres")
                .IsRequired(x => x.LastName, "SobreNome é obrigatório")
                .HasMaxLenght(x => x.LastName, 60)
                .HasMinLenght(x => x.LastName, 3, "Tamanho mínimo 3 caracteres")
                .IsEmail(x => x.Email, "Email inválido");


        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public string Email { get; private set; }
        public User User { get; private set; }

        public void Update(string firstname, string lastname, DateTime birthDate)
        {
            FirstName = FirstName;
            LastName = LastName;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
