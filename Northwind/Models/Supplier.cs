﻿using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }
    }
}
