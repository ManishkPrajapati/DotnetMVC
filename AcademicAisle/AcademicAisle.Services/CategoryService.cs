using AcademicAisle.Database;
using AcademicAsile.entities;
using System.Data.Entity.Migrations;

namespace AcademicAisle.Services
{
    public class CategoryService
    {
        public void saveCategory(Category category)
        {
            using(var context = new AcademicAisleDb())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new AcademicAisleDb())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetCategories(int id)
        {
            using (var context = new AcademicAisleDb())
            {
                return context.Categories.Find(id);
            }
        }

        public void updateCategory(Category category)
        {
            using (var context = new AcademicAisleDb())
            {
                context.Categories.AddOrUpdate(category);
                context.SaveChanges();
            }
        }

        public void deleteCategory(int Id)
        {
            using (var context = new AcademicAisleDb())
            {
                var category = context.Categories.Find(Id);
                context.Categories.Remove(category);
                context.SaveChanges ();
            }
        }
    }
}
