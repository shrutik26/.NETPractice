using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                {
                    if( !context.Employees.Any())
                    {
                        context.Employees.AddRange(new Employee()
                        {
                            Name = "Sharad Saxena",
                            Role = "Software Engineer",
                            Address = "Amravati",
                            ContactNo = "9234234567"
                        },
                         new Employee()
                         {
                             Name = "Abhishek Sharma",
                             Role = "QA",
                             Address = "Indore",
                             ContactNo = "5678022561"

                         });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
