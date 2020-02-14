using System.Collections.Generic;

namespace ProductImport.Models
{
    public class Product
    {
        public List<string> Categories { get; set; }
        public string Twitter { get; set; }
        public string Title { get; set; }
    }

    public class RootObject
    {
        public List<Product> Products { get; set; }
    }
}
