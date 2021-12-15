using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        //Navigation Property (Many To Many)
        public List<Product_Type> product_Types{ get; set; }
    }
}
