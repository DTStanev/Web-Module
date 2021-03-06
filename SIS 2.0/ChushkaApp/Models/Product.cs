﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChushkaApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Type Type { get; set; }
    }
}
