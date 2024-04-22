using Microsoft.VisualBasic;
using StockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Domain.Entities
{
    public class Category
    {
        #region Atributos
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        
        #region Construtores
        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            DomainExceptionValidation.When(name == null, "Invalid Name value");
            DomainExceptionValidation.When(name.Length <= 3, "Invalid name, too short");
            Id = id;
            Name = name;
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> Products { get; set; }
        public object Description { get; set; }
        public object Price { get; set; }
        #endregion

        #region Validação
        private void ValidateDomain(string name, int id)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is required.");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");

            DomainExceptionValidation.When(id < 0, "Invalid Id value.");

            Name = name;
            Id= id;
        }
        #endregion

    }
}
