using FluentAssertions;
using StockApp.Domain.Entities;
using StockApp.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StockApp.Domain.Test
{
        #region Testes Positivos
        public class CategoryUnitTest
        {
            [Fact(DisplayName = "Create Category With Valid Parameters")]
            public void CreateCategory_WithValidParameters_ResultValidState()
            {
                Action action = () => new Category(1, "Category Name");
                action.Should().NotThrow<StockApp.Domain.Validation.DomainExceptionValidation>();
            }

            #endregion

            #region Testes Negativos
            //Id
            [Fact(DisplayName = "Create Category With Invalid Id - Negative")]
            public void CreateCategory_WithInvalidParameters_ShouldThrowValidationException()
            {
                Action action = () => new Category(-1, "Category Name");
                action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid Id value.");
            }

            //Name
            [Fact(DisplayName = "Create Category With Invalid State Name - Empty")]
            public void CreateCategory_WithInvalidEmptyName_ShouldThrowValidationException()
            {
                Action action = () => new Category(1, "");
                action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name, name is required.");
            }

            [Fact(DisplayName = "Create Category With Invalid State Name - Too Short")]
            public void CreateCategory_WithInvalidTooShortName_ShouldThrowValidationException()
            {
                Action action = () => new Category(1, "Ca");
                action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name, too short, minimum 3 characters.");
            }

            [Fact(DisplayName = "Create Category With Invalid State Name - Too Long")]
            public void CreateCategory_WithInvalidTooLongName_ShouldThrowValidationException()
            {
                Action action = () => new Category(1, "tptptptptptptppptptptptptptpppppppptptptptptp" +
                    "tptpptpttptptptptptptpttptptptptptpttptptptptpttptptptptptptptptptptptpPPPPPPP" +
                    "PPPtptptptptptptptptptptptptptptptptptptptpptptptptptptpptptptptptpttpttptptpt" +
                    "tptptptptptptptptptpttptptptptptptptptptptptptptptptptptptptptptptptptptptptpt" +
                    "tptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptpptttptptptptpt" +
                    "tptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptptp");
                action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name, too long, maximus 100 characters.");
            }

            [Fact(DisplayName = "Create Category With Invalid State Name - Null")]
            public void CreateCategory_WithInvalidNullName_ShouldThrowValidationException()
            {
                Action action = () => new Category(1, null);
                action.Should().Throw<StockApp.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name, name is required.");
            }

            #endregion
        }

 }
