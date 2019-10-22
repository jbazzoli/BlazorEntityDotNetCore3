using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelShared
{
    public class Person
    {
        [Key]
        public int idPerrson { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public string birthDay { get; set; }
    }
}
