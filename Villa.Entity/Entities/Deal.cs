﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Deal :BaseEntity
    {
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Square { get; set; }
        public string Floor { get; set; }
        public int RoomCount { get; set; }
        public bool HasParkingArea { get; set; }
        public string PaymentType { get; set; }
    }
}
