using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernStore.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


            new ValidationContract<Name>(this)
                .IsRequired(x => x.FirstName, "Nome é obrigatório")
                .HasMaxLenght(x => x.FirstName, 60)
                .HasMinLenght(x => x.FirstName, 3, "Tamanho mínimo 3 caracteres")
                .IsRequired(x => x.LastName, "SobreNome é obrigatório")
                .HasMaxLenght(x => x.LastName, 60)
                .HasMinLenght(x => x.LastName, 3, "Tamanho mínimo 3 caracteres");
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
