﻿using StockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Domain.Entities
{
    public class Product
    {
 
        #region Atributos
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set;}
        public string Image { get; set; }
        public int CategoryId { get; set; }
        #endregion

        /*
        public Product(int v, string v1)
        {

        }

        public Product(int v, string v1, string v2, decimal v3, int v4, string v5, int v6) : this(v, v1)
        {
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }
        */

        public Product(int id, string name, string description, decimal price, int stock, string image, int category)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = category;
        }
        public Category Category { get; set; }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is required.");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "Invalid description, name is required.");

            DomainExceptionValidation.When(description.Length < 5,
                "Invalid description, too short, minimum 5 characters.");

            DomainExceptionValidation.When(price < 0, "Invalid price negative value.");

            DomainExceptionValidation.When(stock < 0, "Invalid stock negative value.");

            DomainExceptionValidation.When(image.Length > 250, "Invalid image name, too long, maximum 250 characters.");

        }
    }
}