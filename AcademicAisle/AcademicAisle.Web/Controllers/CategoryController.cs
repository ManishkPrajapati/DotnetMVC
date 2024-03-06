using AcademicAisle.Services;
using AcademicAsile.entities;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAisle.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryService categoryService = new CategoryService();

        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        

        [HttpPost]
        public ActionResult Create( Category category)
        {
            categoryService.saveCategory(category);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = categoryService.GetCategories(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.updateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = categoryService.GetCategories(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryService.deleteCategory(category.Id);
            return RedirectToAction("Index");
        }
    }
}
