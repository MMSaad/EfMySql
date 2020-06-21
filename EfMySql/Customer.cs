using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EfMySql
{
   public class Customer
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(5)]
        public string Name { get; set; }
    }
}
