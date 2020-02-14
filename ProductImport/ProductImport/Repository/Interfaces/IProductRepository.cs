using ProductImport.Models;
using System.Collections.Generic;

namespace ProductImport.Repository.Interfaces
{
    public interface IProductRepository
    {
        void SaveProducts(List<Product> products);
        List<Product> GetAllProducts();
    }
}
