using ProductImport.Models;
using System.Collections.Generic;

namespace ProductImport.ImportService.Interfaces
{
    public interface IFileParserStrategy
    {
        List<Product> Parse(string path);
    }
}
