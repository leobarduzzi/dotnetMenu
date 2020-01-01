using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Code { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Type { get; set; }
        
        public bool DeliveryAvailable { get; set; }
        public bool EatAvailable { get; set; }
        public bool TakeAvailable { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DeliveryPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal EatPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TakePrice { get; set; }

        public int Categories_id { get; set; }
        public Categories Category { get; set; }

    }
}