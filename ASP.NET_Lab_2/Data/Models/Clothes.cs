﻿using System.Text;

namespace ASP.NET_Lab_2.Data.Models
{
    public class Clothes
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } // Категорія одягу (для дітей/чоловіків/жінок)
        public int CompanyId { get; set; }
        public int TypeId { get; set; } // Види одягу
        public int ColorId { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
        public Company Company { get; set; }
        public Type Type { get; set; }
        public Color Color { get; set; }
    }
}
