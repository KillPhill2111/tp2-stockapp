﻿using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Domain.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Interface
        public ICollection<Product> Products { get; set; }
    }
}
