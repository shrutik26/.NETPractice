using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class Product_Type
    {
        public int Id { get; set; }


        //Navigation Property (Many To Many)
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

       
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
