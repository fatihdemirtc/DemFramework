﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemFramework.Nortwind.Entities.Concrete;

namespace DemFramework.Nortwind.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductId");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}