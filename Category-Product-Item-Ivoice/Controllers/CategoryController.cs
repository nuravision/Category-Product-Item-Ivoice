using Domain.Models;
using Service.Services.Classes;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category_Product_Item_Ivoice.Controllers
{
    public class CategoryController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }
        public void GetCategoryById()
        {
            int id;
            Console.Write("Enter id:");
            id = Int32.Parse(Console.ReadLine());
            var result = _categoryService.GetCategoryById(id);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
        public void GetAllCategory()
        {
            var result = _categoryService.GetAllCategories();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void AddCategory()
        {
            Console.Write("Enter new category name:");
            string name = Console.ReadLine();
            _categoryService.AddCategory(new Category(name));
        }
        public void DeleteCategoryById()
        {
            Console.Write("Enter category id: ");
            if (int.TryParse(Console.ReadLine(), out int deletedId))
            {
                bool isDeleted = _categoryService.DeleteCategory(deletedId);
                if (isDeleted)
                {
                    Console.WriteLine("Category deleted!");
                }
                else
                {
                    Console.WriteLine("Category not found!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        public void UpdateCategory()
        {
            Console.Write("Enter id:");
            int id = Int32.Parse(Console.ReadLine());
            if (_categoryService.UpdateCategory(id) != null)
            {
                Console.WriteLine("Category updated successfully!");
            }
            else
            {
                Console.WriteLine("Category not found!");
            }

        }

    }
}
