﻿using System;
using System.Collections.Generic;

namespace WebAdmin.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }

    }
}
