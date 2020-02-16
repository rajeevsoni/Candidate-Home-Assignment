using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductImport.ImportService;
using ProductImport.ImportService.Interfaces;
using ProductImport.Models;
using System;

namespace ProductImport.Test
{
    [TestClass]
    public class FileParserContextTest
    {
        private FileParserContext fileParserContext;
        private Func<FileType, IFileParserStrategy> strategyProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            strategyProvider = GetStrategy;
            fileParserContext = new FileParserContext(strategyProvider);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ParseProductTest_FileNotSupported()
        {
            var filePath = "D:\\softwareadvice.pdf";
            fileParserContext.ParseProducts(filePath);

        }

        Func<FileType, IFileParserStrategy> GetStrategy = fileType => {
            switch (fileType)
            {
                case FileType.json: return new JSONFileParserStrategy();
                case FileType.yaml: return new YAMLFileParserStrategy();
                default: throw new NotSupportedException("filetype not supported.");
            }
        };

    }
}
