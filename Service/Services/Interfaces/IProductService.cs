using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        bool DeleteProduct(int id);
        Product UpdateProduct(int id);
        Product GetProductById(int id);
        void AddProduct(Product newProduct);

    }
}
