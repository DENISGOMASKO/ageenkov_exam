using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamWPF.Models
{
    class ProductsInOrder
    {
        [Key]
        public int pio_id { get; set; }   
        /*public int order_id_f { get; set; }
        public Order order { get; set; }
        public int product_id_f { get; set; }
        public Product product { get; set; }
        public int count { get; set; }*/
    }
}
