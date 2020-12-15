﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VänstraSidan.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int? InventoryId { get; set; }
        public Inventory Inventory { get; set; }

    }
}
