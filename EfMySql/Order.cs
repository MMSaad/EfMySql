using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EfMySql
{
   public class Order
    {

        [Key]
        public long Id { get; set; }


        public virtual Customer Customer { get; set; }
        [Required] public long CustomerId { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
