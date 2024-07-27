﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllupPB301.Models
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isBestSeller { get; set; }
        public bool isNewArrival { get; set; }
        public bool isFeatured { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExTax { get; set; }
        public int DiscountRate { get; set; }
        public int Count { get; set; }
        //[Range(0,999)]
        public int Seria { get; set; }
        //[MaxLength(4)]
        public string Code { get; set; }
        public string MainImage { get; set; }
        public string HoverImage { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand { get; set;}
        public int? CategoryId { get; set; }
        public Category Categories { get; set; }
        public List<ProductImage> ProductImages { get; set;}

    }
}
