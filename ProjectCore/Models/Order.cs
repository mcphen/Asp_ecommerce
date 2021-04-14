﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdresseLine1 { get; set; }
        public string AdresseLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal OrderTotal { get; set; }

        public DateTime OrderCreateDate { get; set; } 
    }
}
