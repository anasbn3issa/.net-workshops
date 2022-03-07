using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;

namespace PS.Data.myConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //configuring many to many relation 
            builder.HasMany(p => p.Providers).WithMany(p => p.Products).UsingEntity(t=>t.ToTable("Providings"));
            //configuring 0.1 <=> * relation 
            builder.HasOne(p => p.Category).WithMany(c => c.Products).OnDelete(DeleteBehavior.Cascade);
            /*configuring 1.1 <=> * relation 
            builder.HasOne(p => p.Category).WithMany(c => c.Products).OnDelete(DeleteBehavior.Cascade).IsRequired();*/

            /*
            //configuring inheritance tph (table per hierarchy)
            builder.HasDiscriminator<int>("isBiological")
                .HasValue<Product>(0)
                .HasValue<Biological>(1)
                .HasValue<Chemical>(2);
            */

        }
    }
}
