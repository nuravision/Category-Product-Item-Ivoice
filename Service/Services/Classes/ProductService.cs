using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Classes
{
    public class ProductService:IProductService
    {
        private readonly List<Product> _products;
        private readonly List<Category> _categories;
        public ProductService()
        {
            _products = new List<Product>
            {
                new Product("Iphone13",new Category("phone"),2000),
                new Product("Iphone15",new Category("phone"),3000),
                new Product("MacBoock",new Category("laptop"),5000),
                new Product("Samsung",new Category("televisor"),2000),
            };
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
        public bool DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(c => c.Id == id);
            if (product != null)
            {
                _products.Remove(product);
                return true;
            }
            return false;

        }
        public Product UpdateProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Console.Write("Enter new name:");
                string newName=Console.ReadLine();
                product.Name = newName;
                return product;
            }
            else
            {
                return null;
            }
        }
        public Product GetProductById(int id)
        {
            var result = _products.FirstOrDefault(p => p.Id == id);
            if (result!=null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public void AddProduct(Product newProduct)
        {
            List<Product> products = GetAllProducts();
            products.Add(newProduct);
        }
    }
}
