using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        
        //Navigation Property (One To Many)
        public int? DepartmentId { get; set; }
        public Department department { get; set; }

        //Navigation Property (Many To Many)
        public List<Product_Type> product_Types { get; set; }
    }
}
