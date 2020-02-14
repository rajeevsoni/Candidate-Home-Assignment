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
                var root = JsonConvert.DeserializeObject<RootObject>(json);
                return root.Products;
            }
        }
    }
}
