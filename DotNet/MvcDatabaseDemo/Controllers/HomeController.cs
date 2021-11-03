using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDatabaseDemo.Models;

namespace MvcDatabaseDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            NorthwindContext context = new();
            List<Customer> allCustomers = context.Customers.ToList();

            ViewBag.AllCustomers = allCustomers;

            return View();
        }

        public IActionResult Orders(int id) // Added parameter value
        {
            NorthwindContext context = new();
            List<Order> allOrders = (from o in context.Orders   // LINQ query, o is a variable that holds a single order
                                    where o.EmployeeId == id
                                    orderby o.OrderDate descending
                                    select o).ToList();

            ViewBag.AllOrders = allOrders;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
