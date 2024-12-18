﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category
    {
        private static int Counter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Category()
        {
            Id = Counter++;
        }
        public Category(string name)
        {
            Name = name;
            Id = Counter++;
        }
        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\n";
        }
    }
}
