﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopWebApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    }
}
