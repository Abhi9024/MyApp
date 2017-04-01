using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsert.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string CategoryID { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public int Quantity { get; set; }
    }
}
