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
        private Mock<Func<FileType, IFileParserStrategy>> strategyProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            strategyProvider = new Mock<Func<FileType, IFileParserStrategy>>();
            fileParserContext = new FileParserContext(strategyProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ParseProductTest_FileNotSupported()
        {
            var filePath = "D:\\softwareadvice.pdf";
            fileParserContext.ParseProducts(filePath);

        }
    }
}
