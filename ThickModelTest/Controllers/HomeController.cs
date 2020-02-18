using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThickModelTest.Model;

namespace ThickModelTest.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Company company = new Company("Microsoft", 100000);
            return company.GetInfo();
        }
    }
}