using ProductImport.Models;
using ProductImport.Repository.Interfaces;
using System.Collections.Generic;

namespace ProductImport.Repository
{
    public class SQLProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            //todo implement get products from sql
            return new List<Product>();
        }

        public void SaveProducts(List<Product> products)
        {
            //todo implement save Product to sql db
        }
    }
}
