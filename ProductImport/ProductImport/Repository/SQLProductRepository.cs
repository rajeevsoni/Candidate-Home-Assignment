using ProductImport.Models;
using ProductImport.Repository.Interfaces;
using System.Collections.Generic;

namespace ProductImport.Repository
{
    public class SQLProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {
            //todo add implementation
        }

        public void AddRange(IEnumerable<Product> entities)
        {
            //todo add implementation
        }

        public void Delete(Product entity)
        {
            //todo add implementation
        }

        public void DeleteRange(IEnumerable<Product> entities)
        {
            //todo add implementation
        }

        public Product Get(int id)
        {
            //todo add implementation
            return new Product();
        }

        public void Update(Product entity)
        {
            //todo add implementation
        }

        public void UpdateRange(IEnumerable<Product> entities)
        {
            //todo add implementation
        }
    }
}
