using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThickModelTest.Model
{
    public class Company
    {
        private string Name { get; set; }
        private int Employees { get; set; }
        public Company(string name, int emp)
        {
            this.Name = name;
            this.Employees = emp;
        }
        public string GetInfo()
        {
            return $"Company = {Name}, Employees = {Employees}";
        }
    }
}
