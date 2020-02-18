using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlainModelTest.Model;

namespace PlainModelTest.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Company company = new Company
            {
                Name = "Microsoft",
                Employees = 10000
            };
            string result = $"Company name = {company.Name}, enployees = {company.Employees}";
            return result;
        }
    }
}