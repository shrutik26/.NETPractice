using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassImpl
{
    public class Employee
    {
        private string name;
        private int salary;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0},{1}", name, salary);

            return sb.ToString();
        }
    }
}
