using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.ToTable("Branches");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.UserManagerId)
          .IsRequired();
       
        builder.Property(u => u.CreatedAt).IsRequired();
        builder.Property(u => u.UpdatedAt);
        
        // builder
        //   .HasOne(e => e.Manager);
        // builder
        //   .HasOne(e => e.Stock);
        // builder
        //   .HasMany(e => e.Sales);
        //   // .WithOne(e => e.Branch)
        //   // .HasForeignKey(e => e.BranchId);
    }
}

