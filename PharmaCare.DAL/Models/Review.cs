﻿namespace PharmaCare.DAL.Models
{
    public class Review : BaseEntity
    {
            public DateTime ReviewDate { get; set; }
            public int Rating { get; set; }
            public string Comment { get; set; }

            // Review on product
            public int ProductId { get; set; }
            public virtual Product? Product { get; set; }    

            // Customer 
            public int CustomerId { get; set; }
            public virtual Customer? Customer { get; set; }
    }
    
}
