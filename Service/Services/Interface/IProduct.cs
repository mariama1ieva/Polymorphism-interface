using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Models;

namespace Service.Services.Interface
{
    public interface IProduct
    {
        Product[] GetAll();
        Product[] GetCountOfProduct();
        Product[] SortName(string productName);

        void AvarageOfProduct();

      Category[] GetProductNameByCategory(string categoryText);

        Category[] AllCategory();

      

    }
}
