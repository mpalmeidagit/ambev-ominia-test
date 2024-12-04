using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.UserClientId)
          .IsRequired();
        builder.Property(u => u.SaleValue)
          .IsRequired();

        builder.Property(u => u.Cancelled);
        builder.Property(u => u.Finished);
       
        builder.Property(u => u.CreatedAt).IsRequired();
        builder.Property(u => u.UpdatedAt);
        
        // builder
        //   .HasOne(e => e.Client);
        // builder
        //   .HasMany(s => s.SalesProducts);
        //   // .WithOne(sp => sp.Sale)
        //   // .HasForeignKey(sp => sp.SaleId);
       
        // builder
        //   .HasOne(e => e.Branch);
        //   // .WithMany(e => e.Sales)
        //   // .HasForeignKey(e => e.BranchId)
        //   // .IsRequired();
    }
}

