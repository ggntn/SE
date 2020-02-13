using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dhip.Models.db
{
    public partial class Product4
    {
        [Key]
        public int productId { get; set; }

        public int DetailId { get; set; }
        public int UnitId { get; set; }
        public int CategoryId { get; set; }

    }
}
