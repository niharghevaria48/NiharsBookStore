using Microsoft.AspNetCore.Mvc;
using NiharsBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiharsBookstore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
         //API Calls
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitofwork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }

}
