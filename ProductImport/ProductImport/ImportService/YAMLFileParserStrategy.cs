using ProductImport.ImportService.Interfaces;
using ProductImport.Models;
using System.Collections.Generic;

namespace ProductImport.ImportService
{
    public class YAMLFileParserStrategy : IFileParserStrategy
    {
        public List<Product> Parse(string path)
        {
            //todo write implementation for parsing yaml files
            return new List<Product>();
        }
    }
}
