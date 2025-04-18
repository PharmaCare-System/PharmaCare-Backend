﻿namespace PharmaCare.DAL.Models
{
    public class PharmacistChats
    {
        public int PharamcistId { get; set; }
        public int ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
        public virtual Pharmacist? Pharmacist { get; set; }
    }
}
