﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaCare.DAL.Models.ProductRel;

namespace PharmaCare.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        // relations
        public virtual ICollection<Product>? Medicines { get; set; }

        public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
    }
}
