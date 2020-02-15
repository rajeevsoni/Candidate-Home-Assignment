using Newtonsoft.Json;
using ProductImport.ImportService.Interfaces;
using ProductImport.Models;
using System.Collections.Generic;
using System.IO;

namespace ProductImport.ImportService
{
    public class JSONFileParserStrategy : IFileParserStrategy
    {
        public List<Product> Parse(string path)
        {
            using (var reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                var productList = JsonConvert.DeserializeObject<ProductList>(json);
                return productList.Products;
            }
        }
    }
}
