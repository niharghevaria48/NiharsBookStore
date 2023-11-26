﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NiharsBooks.DataAccess.Repository.IRepository;
using NiharsBooks.Models;
using NiharsBookstore.Models;
using NiharsBookstore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NiharsBookstore.Area.Customer.Controllers

{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unifOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
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
    }
}
