using System;
using System.Collections.Generic;

namespace dhip.Models.db
{
    public partial class ProductDetail
    {
        public int productDetailId { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public int laborCost { get; set; }
        public int productId { get; set; }
    }
}
