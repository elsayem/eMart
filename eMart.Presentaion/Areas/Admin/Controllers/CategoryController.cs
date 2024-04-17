using eMart.DataAccess.Context;
using eMart.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using eMart.Business.ViewModels;

namespace eMart.Presentaion.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
       private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<CategoryVM> vmodel = _db.Categories.Select(x=> new CategoryVM
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsDeleted = x.IsDeleted,

            }).ToList();


            return View(vmodel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            var model = _db.Categories.ToList();

            return View(model);

        }

       
    }
}
