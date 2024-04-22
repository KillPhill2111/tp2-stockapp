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
            Id = id;
            Name = name;
            ValidateDomain(id, name);
        }
        #endregion

        public ICollection<Product>? Products { get; set; }

        #region Validação
        private static void ValidateDomain(int id, string name)
        {

            DomainExceptionValidation.When(id < 0,
                "Invalid Id value.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is required.");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");

            DomainExceptionValidation.When(name.Length > 100,
                "Invalid name, too long, maximus 100 characters.");
        }

        #endregion
    }
}
