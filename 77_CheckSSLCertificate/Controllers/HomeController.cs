using _77_CheckSSLCertificate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _77_CheckSSLCertificate.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Test_Method_1_Without_SSL")]
        [HttpGet]
        public async Task<string> TestMethod1WithoutSSL()
        {
            var modelOneObj = new ModelOne();
            return modelOneObj.Method1();
        }

        [Route("Test_Method_2_With_SSL_Check")]
        [HttpGet]
        public async Task<string> TestMethod2WithSSLCheck()
        {
            var modelOneObj = new ModelOne();
            return modelOneObj.Method2();
        }

    }
}
