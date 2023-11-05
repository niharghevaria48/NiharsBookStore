using Microsoft.AspNetCore.Mvc;
using NiharsBooks.DataAccess.Repository;
using NiharsBooks.DataAccess.Repository.IRepository;
using NiharsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiharsBookstore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) //action method for upsert
        {
            Category category = new Category();//using NiharBooks.Models;
            if (id == null)
            {
                // this is to creatte
                return View(category);
            }

            //this for the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }
         //API Calls
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }

}
