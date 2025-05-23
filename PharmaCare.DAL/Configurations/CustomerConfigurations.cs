﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using PharmaCare.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaCare.DAL.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

           
            builder.Property(x => x.CreatedDateTime)
                   .HasColumnType("DATE");



            builder.Property(x => x.ModifiedDateTime)
                   .HasColumnType("DATE");



            builder.Property(x => x.DeletedDateTime)
                   .HasColumnType("DATE");

            builder.Property(x => x.IsDeleted)
                    .HasDefaultValue(false)
                    .HasColumnType("BIT");
            //---------------------


        // Relations

            // customer has chat ( 1 to 1 )
            builder.HasOne(c => c.Chat)
                   .WithOne(ch => ch.Customer)
                   .HasForeignKey<Chat>(ch => ch.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Customer Has ShoppingCart (1 to 1) 
            builder.HasOne(c => c.ShoppingCart)
                   .WithOne(sh => sh.Customer)
                   .HasForeignKey<ShoppingCart>(sh => sh.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            // customer Receive Purchase ( 1 to N)
            builder.HasMany(c => c.Purchases)
                   .WithOne(p => p.Customer)
                   .HasForeignKey(p => p.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Customer Make Review (1 to N)
            builder.HasMany(c => c.Reviews)
                   .WithOne(r => r.Customer)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Customer upload prescription (1 to N)
            builder.HasMany(c => c.Prescriptions)
                   .WithOne(p => p.Customer)
                   .HasForeignKey(p => p.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Customer Take Order ( 1 to N)
            builder.HasMany(c => c.Orders)
                   .WithOne(o => o.Customer)
                   .HasForeignKey(o => o.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
