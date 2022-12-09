using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamWPF.Models
{
    class Person
    {
        [Key]
        public int person_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string telephone_number { get; set; }

    }
}
