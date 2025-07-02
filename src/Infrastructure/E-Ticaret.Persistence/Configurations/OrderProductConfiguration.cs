﻿using E_Ticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Persistence.Configurations;
public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
        builder.ToTable("OrderProducts");

        builder.HasKey(op => op.Id); 

        
        builder.HasOne(op => op.Order)
               .WithMany(o => o.OrderProducts)
               .HasForeignKey(op => op.OrderId)
               .OnDelete(DeleteBehavior.Restrict); 
        
        builder.HasOne(op => op.Product)
               .WithMany(p => p.OrderProducts)
               .HasForeignKey(op => op.ProductId)
               .OnDelete(DeleteBehavior.Restrict); 
    }
}