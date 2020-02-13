using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dhip.ViewModels
{
    public class AdminClaimViewModel
    {
        public string name { get; set; }
        public int price { get; set; }
        public int laborCost { get; set; }
        public string unit { get; set; }
        public int categoryId { get; set; }
    }
}
