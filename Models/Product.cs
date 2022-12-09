using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamWPF.Models
{
    class Product
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public List<ProductsInOrder> orders { get; set; }
    }
}
