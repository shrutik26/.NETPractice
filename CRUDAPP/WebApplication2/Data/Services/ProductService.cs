using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;
using WebApplication2.Data.ViewModel;

namespace WebApplication2.Data.Services
{
    public class ProductService
    {
        private AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProduct(ProductVm productVm)
        {
            Product _product = new Product()
            {
                ProductName = productVm.ProductName
            };
            _context.Products.Add(_product);
            _context.SaveChanges();
        }

        public ProductWithEmployeeVm GetProductWithEmployeeVm(int productId)
        {
            var _productwithEmployee = _context.Products.Where(e => e.ProductId == productId).Select(product => new ProductWithEmployeeVm()
            {
                ProductName = product.ProductName,
                EmployeeName = product.product_Types.Select(b => b.Employee.Name).ToList()
            }).FirstOrDefault();
            return _productwithEmployee;
        }
    }
}
