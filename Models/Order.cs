using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamWPF.Models
{
    class Order
    {
        [Key]
        public int order_id { get; set; }
        public int person_id_f { get; set; }
        public string address { get; set; }
        public DateTime date { get; set; }
        public List<ProductsInOrder> products { get; set; }
}
}
