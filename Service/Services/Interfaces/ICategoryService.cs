using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category newCategory);
        bool DeleteCategory(int id);
        Category UpdateCategory(int id);
    }
}
