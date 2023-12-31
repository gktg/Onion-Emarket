﻿using Onion_Emarket.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion_Emarket.Domain.ViewModels
{
    public class ProductVM
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }

        public string Media { get; set; }

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        
        public int Quantity { get; set; }
    }
}
