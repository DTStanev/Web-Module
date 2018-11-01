﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChushkaApp.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public User Client { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime OrderedOn { get; set; } = DateTime.UtcNow;

    }
}
