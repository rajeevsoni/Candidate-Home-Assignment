using Microsoft.Extensions.DependencyInjection;
using ProductImport.ImportService;
using ProductImport.StartupConfiguration;
using System;

namespace ProductImport
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.ConfigureServices();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            //input file path
            Console.WriteLine("Product Import Service");
            Console.WriteLine("Enter File Path:");
            var filePath = Console.ReadLine();

            var fileParser = serviceProvider.GetService<FileParserContext>();
            var products = fileParser.ParseProducts(filePath);

            Console.WriteLine("Exporting products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Title}, Twitter: {product.Twitter}");
            }


        }
    }
}
