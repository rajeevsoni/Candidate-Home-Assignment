using ProductImport.ImportService.Interfaces;
using ProductImport.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProductImport.ImportService
{
    public class FileParserContext
    {
        private readonly Func<FileType, IFileParserStrategy> strategyProvider;
        
        public FileParserContext(Func<FileType, IFileParserStrategy> strategyProvider)
        {
            this.strategyProvider = strategyProvider;
        }

        public List<Product> ParseProducts(string filePath)
        {
            var fileExtension = Path.GetExtension(filePath).Replace(".", string.Empty);
            Enum.TryParse(fileExtension, out FileType fileType);
            var strategy = strategyProvider(fileType);
            return strategy.Parse(filePath);
        }
    }
}
