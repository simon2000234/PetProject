﻿using System;

namespace Core.Entities
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public string PreviousOwner { get; set; }
        public double Price { get; set; }

    }
}
