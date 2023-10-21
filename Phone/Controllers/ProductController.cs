using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Services;
using Domain.Models;
using Domain;
using Service.Services;

namespace Phone.Controllers
{
    internal class ProductController
    {
        private readonly IProduct product;
        public ProductController()
        {
             product = new ProductService();
        }
        

        public void ShowProducts()
        {
            var products=product.GetAll();
            foreach (var product in products)
            {
                var result =$"{ product.Name }-{ product.Price}-{product.Category.Name}-{product.CreatedDate}";
                Console.WriteLine(result);
            }
        }

        public void CountOfProduct()
        {
           var products= product.GetAll();
            int count = 0;
           for(var i = 0;i<products.Length;i++)
            {

                count++;
                
            }
            Console.WriteLine(count);
        }

        public void ShowProductByName()
        {
            string productName = Console.ReadLine();

            Product[] products=product.GetAll();

            foreach (var product in products)
            {
                if (product.Name == productName)
                {
                    Console.WriteLine($"{product.Name} {product.Price} {product.Category.Name} {product.Category}");
                }
            }
        }

        public void ShowAvarageOfProduct()
        {
            var products = product.GetAll();
            int sum = 0;
            int count = 0;
            foreach (var product in products)
            {
                sum += product.Price;
                count++;
            }
            Console.WriteLine(sum / count);
        }

        


        }


        

       
    }
}
