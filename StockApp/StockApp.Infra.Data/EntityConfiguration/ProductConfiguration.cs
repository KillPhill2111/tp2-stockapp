using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Infra.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //primary key
            builder.HasKey(t => t.Id);
            //maxlength nome
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            //maxlength description
            builder.Property(p => p.Description).HasMaxLength(250).IsRequired();
            //maxlength decimal do price
            builder.Property(p => p.Price).HasPrecision(10,2);
            //chave estrangeira de categoria build hashOne => WithMany HasForeignKey (Atributo)
            builder.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);
        }

    }
}
