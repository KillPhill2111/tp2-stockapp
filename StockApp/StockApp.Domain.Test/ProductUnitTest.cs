using FluentAssertions;
using StockApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StockApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Product With Valid Parameters")]
        public void CreateProduct_WithValidParameters_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Id")]
        public void CreateProduct_WithValidId_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Name")]
        public void CreateProduct_WithValidName_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Description")]
        public void CreateProduct_WithValidDescription_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Price")]
        public void CreateProduct_WithValidPrice_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 10.50m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Stock")]
        public void CreateProduct_WithValidStock_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid Image")]
        public void CreateProduct_WithValidImage_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With Valid CategoryId")]
        public void CreateProduct_WithValidCategoryId_ResultValidState()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 10.50m, 100, "image_product.jpg", 1);
            action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos
        //Id
        [Fact(DisplayName = "Create Product With Invalid Id - Negative")]
        public void CreateProduct_WithInvalidNegativeId_ShouldThrowValidationException()
        {
            Action action = () => new Product(-1, "Product", "Valid Description", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid id negative value");
        }

        //Name
        [Fact(DisplayName = "Create Product With Invalid Name - Empty")]
        public void CreateProduct_WithInvalidEmptyName_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "", "Valid Description", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name - Null")]
        public void CreateProduct_WithInvalidNullName_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, null, "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name - Too Short")]
        public void CreateProduct_WithInvalidShortName_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "tp", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Name - Too Long")]
        public void CreateProduct_WithInvalidLongName_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "tptptptptptptppptptptptptptpppppppptptptptptp" +
                "tptpptpttptptptptptptpttptptptptptpttptptptptpttptptptptptptptptptptptpPPPPPPP" +
                "PPPtptptptptptptptptptptptptptptptptptptptpptptptptptptpptptptptptpttpttptptpt" +
                "tptptptptptptptptptpttptptptptptptptptptptptptptptptptptptptptptptptptptptptpt" +
                "tptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptpptttptptptptpt" +
                "tptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptp", "Valid Description Validation", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too long, maximus 100 characters.");
        }

        //Description
        [Fact(DisplayName = "Create Product With Invalid Description - Empty")]
        public void CreateProduct_WithInvalidEmptyDescription_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description - Null")]
        public void CreateProduct_WithInvalidNullDescription_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", null, 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, description is required.");
        }

        [Fact(DisplayName = "Create Product With Invalid Description - Too Short")]
        public void CreateProduct_WithInvalidShortDescription_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Desc", 7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        //Price
        [Fact(DisplayName = "Create Product With Invalid Price - Negative")]
        public void CreateProduct_WithInvalidPrice_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", -7.8m, 100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }

        //Stock
        [Fact(DisplayName = "Create Product With Invalid Stock - Negative")]
        public void CreateProduct_WithInvalidStock_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, -100, "image_product.jpg", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }

        //Stock
        [Fact(DisplayName = "Create Product With Invalid Image - Empty")]
        public void CreateProduct_WithInvalidEmptyImage_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, image name is required");
        }

        //Image
        [Fact(DisplayName = "Create Product With Invalid Image - Too Long")]
        public void CreateProduct_WithInvalidLongImage_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100,
                "O_nome_desta_não_pode_passar_de_250_letras_por_isso_o_nome_desta_imagem" +
                "_não_pode_ser_muito_longa_por_esse_motivo_criamos_esta_validação_para" +
                "_verificar_se_esta_condição_não_é_atendida_através_de_um_teste_unitário_" +
                "de_software_que_valida_através_de_lógica_O_nome_desta_não_pode_passar_de" +
                "_250_letras_por_isso_o_nome_desta_imagem_não_pode_ser_muito_longa_por_" +
                "esse_motivo_criamos_esta_validação_para_verificar_se_esta_condição_não_" +
                "é_atendida_através_de_um_teste_unitário_O_nome_desta_não_pode_passar_de" +
                "_250_letras_por_isso_o_nome_desta_imagem_não_pode_ser_muito_longa_por" +
                "_esse_motivo_criamos_esta_validação_para_verificar_se_esta_condição_não" +
                "_é_atendida_através_de_um_teste_unitário_de_software_que_valida_através" +
                "_de_lógica_O_nome_desta_não_pode_passar_de_250_letras_por_isso_o_nome" +
                "_desta_imagem_não_pode_ser_muito_longa_por_esse_motivo_criamos_esta_" +
                "validação_para_verificar_se_esta_condição_não_é_atendida_através_de_um" +
                "_teste_unitário_validação_para_verificar_se_esta_condição_não_é_atendida" +
                "_através_de_um", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product With Invalid Image - Empty")]
        public void CreateProduct_WithInvalidEmpty_ShouldThrowValidationException()
        {
            Action action = () => new Product(1, "Product", "Valid Description Validation", 7.8m, 100, "", 1);
            action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, image name is required");
        }
        #endregion
    } 
}
  
