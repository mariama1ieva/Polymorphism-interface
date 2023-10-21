using Domain;
using Domain.Models;
using Service.Services.Interface;


namespace Service.Services
{
    public class ProductService : IProduct
    {
       
        private Category[] categories;
        private int productCount = 0;

        private Product[] products;

        public ProductService()

        {
          categories= new Category[]
            {
            new Category { Id = 1, Name = "Android" },
            new Category { Id = 2, Name = "IOS" },
            new Category { Id = 3, Name = "Smartphone" },
            };
           
        }

        private Product[] GetProducts()
        {
            return new Product[]
            {
            new Product { Id = 1, Name = "Iphone15", Price = 3500, CreatedDate = new DateTime(2023, 10, 9), Category = categories[1] },
            new Product { Id = 2, Name = "SamsungS30", Price = 2000, CreatedDate = new DateTime(2022, 11, 6), Category = categories[0] },
            new Product { Id = 3, Name = "Nokia", Price = 1000, CreatedDate = new DateTime(2019, 7, 15), Category = categories[2] },
            new Product { Id = 4, Name = "Iphone13", Price = 2500, CreatedDate = new DateTime(2021, 10, 10), Category = categories[1] },
            new Product { Id = 5, Name = "SamsungS4", Price = 700, CreatedDate = new DateTime(2016, 6, 22), Category = categories[0] },
            };
        }
       
        public Product[] GetAll()
        {
            return GetProducts();
        }

        public Category[] AllCategories()
        {
            return categories;
        }

        Product[] IProduct.GetCountOfProduct()
        {
            Product[] products = GetAll();
            return products;
        }

        Product[] IProduct.SortName(string productName)
        {
            var product = GetAll();
            return product.Where(x => x.Name ==productName).ToArray();
        }

        void IProduct.AvarageOfProduct()
        {
            
        }

       
    }
}
