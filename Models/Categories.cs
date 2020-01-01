using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Menu.Models
{
    public class Categories
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }
    
        public List<Products> products { get; set; }

    }
}

