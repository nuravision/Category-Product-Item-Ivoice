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
    public class ProductController
    {
        private readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        public void GetAllShowProducts()
        {
            var result = _productService.GetAllProducts();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void DeleteProductById()
        {
            Console.Write("Enter product id: ");
            if (int.TryParse(Console.ReadLine(), out int deletedId))
            {
                bool isDeleted = _productService.DeleteProduct(deletedId);
                if (isDeleted)
                {
                    Console.WriteLine("Product deleted!");
                }
                else
                {
                    Console.WriteLine("Product not found!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        public void  UpdateProduct()
        {

            Console.Write("Enter updated id:");
            int updatedId=Int32.Parse(Console.ReadLine());
            var result = _productService.UpdateProduct(updatedId);
            if (result!=null)
            {
                Console.WriteLine("Product updated!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }

        }
        public void GetProductById()
        {
            Console.Write("Enter id:");
            int id=Int32.Parse(Console.ReadLine());
            var result = _productService.GetProductById(id);
            if (result != null) {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
        public void AddProduct()
        {
            Console.Write("Enter new product name:");
            string newProductName=Console.ReadLine();
            Console.Write("Enter new product price:");
            decimal newProductPrice=Decimal.Parse(Console.ReadLine());
            Console.Write("Enter category name:");
            string newCategoryName = Console.ReadLine();
            Product newProduct=new Product(newProductName, new Category(newCategoryName),newProductPrice);
            _productService.AddProduct(newProduct);
            Console.WriteLine("Product added!");
        }

    }
}
