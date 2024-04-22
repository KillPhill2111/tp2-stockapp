using FluentAssertions;
using StockApp.Domain.Entities;
using StockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Domain.Test
{
    public class ProductUnitTest
    {
        [Fact(DisplayName = "Create Product With Valid Parameters")]
        public void CreateProduct_WithValidParameters_ShouldNotThrowValidationException()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Id")]
        public void CreateProduct_WithValidId_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Name")]
        public void CreateProduct_WithValidName_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Description")]
        public void CreateProduct_WithValidDescription_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Price")]
        public void CreateProduct_WithValidPrice_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Stock")]
        public void CreateProduct_WithValidStock_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Image")]
        public void CreateProduct_WithValidImage_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid CategoryId")]
        public void CreateProduct_WithValidCategoryId_ResultValidState()
        {
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        //-----------------------------------------------------------------------
        [Fact(DisplayName = "Create product with null description")]
        public void CreateProduct_WithNullDescription_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Name", null,10.50m, 100, "image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid description, name is required.");
        }
        [Fact(DisplayName = "Create product with short description")]
        public void CreateProduct_WithShortDescription_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "valid name", "de",
                10.50m, 100, "image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }
        //-----------------------------------------------------------------------

        [Fact(DisplayName = "Create Product With Invalid Name - Empty")]
        public void CreateProduct_WithInvalidEmptyName_ShouldThrowValidationException()
        {
            string invalidName = "";
            Action action = () => new Product(1, invalidName, "Valid description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }
        //---------------------------------------------------------------------------
        [Fact(DisplayName ="Create Product With Valid Name")]
        public void CreateCategory_WithInvalidNameNull_ResultInvalidState()
        {
            Action action = () => new Product(1, null, "description", 10.5m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, name is required.");
        }
        //-------------------------------------------------------------------------------------

        [Fact(DisplayName = "Create Product With Invalid Name - Too Short")]
        public void CreateProduct_WithInvalidShortName_ShouldThrowValidationException()
        {
            
            Action action = () => new Product(1, "NA", "description", 10.50m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }
        

        [Fact(DisplayName = "Create Product With Invalid Description - Too Short")]
        public void CreateProduct_WithInvalidShortDescription_ShouldThrowValidationException()
        {
            string invalidDescription = "DESC";
            Action action = () => new Product(1, "Test Product", invalidDescription, 10.50m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description - Empty")]
        public void CreateProduct_WithInvalidEmptyDescription_ShouldThrowValidationException()
        {
            string invalidDescription = "";
            Action action = () => new Product(1, "Test Product", invalidDescription, 10.50m, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Price")]
        public void CreateProduct_WithInvalidPrice_ShouldThrowValidationException()
        {
            decimal invalidPrice = -10.50m;
            Action action = () => new Product(1, "Test Product", "Valid description", invalidPrice, 100, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }

        [Fact(DisplayName = "Create Product With Invalid Stock")]
        public void CreateProduct_WithInvalidStock_ShouldThrowValidationException()
        {
            int invalidStock = -100;
            Action action = () => new Product(1, "Test Product", "Valid description", 10.50m, invalidStock, "test_image.jpg", 1);
            action.Should().Throw<DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }
    }
}
