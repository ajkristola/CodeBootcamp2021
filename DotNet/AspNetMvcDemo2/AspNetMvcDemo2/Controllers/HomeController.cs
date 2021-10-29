using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetMvcDemo2.Models;

namespace AspNetMvcDemo2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FileSum()
        {
            string filename = @"/source/code_bootcamp/DotNet/FileSum/numbers.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            int sum = 0;
            int currentLine = 1;

                 foreach (string line in lines)

                {
                    try
                    {
                        int value = int.Parse(line);
                        sum += value;
                    }
                    catch
                    {
                    ViewBag.ErrorMessage = "Could not read line \"" + line + "\" on line "
                                        + currentLine + ", not a number.";
                    }
                    currentLine++;
                }

            ViewBag.SourceOfData = filename;
            ViewBag.CalculatedSum = sum;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
