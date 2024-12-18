using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Classes
{
    public class CategoryService:ICategoryService
    {
        private readonly List<Category> _categories;
        public CategoryService()
        {
            _categories = new List<Category>
            {
                new Category { Name = "Phone" },
                new Category {Name = "Televisor" },
                new Category { Name = "Laptop" },
                new Category { Name = "Wooden" },
                new Category { Name = "Mebel" },
                new Category {  Name = "Electronics" }
            };

        }
        public List<Category> GetAllCategories()
        {
            return _categories;
        }
        public Category GetCategoryById(int id)
        {
            var result = GetAllCategories();
            foreach (var category in result)
            {
                if (category.Id == id)
                {
                    return category;
                }
            }
            return null;
        }

        public void AddCategory(Category newCategory)
        {
            List<Category> categories = GetAllCategories();
            categories.Add(newCategory);
        }

        public bool DeleteCategory(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
                return true;
            }
            return false;
        }

        public Category UpdateCategory(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                Console.Write("Enter new name:");
                string newName = Console.ReadLine();
                category.Name = newName;
                return category;
            }
            else
            {
                return null;
            }


        }
    }
}
