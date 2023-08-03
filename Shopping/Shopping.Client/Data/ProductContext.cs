using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name= "Iphone",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 950.00M,
                Category="SmartPhone"
            },
          new Product()
            {
                Name= "Samsung 5g",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 910.00M,
                Category="SmartPhone"
            },
            new Product()
            {
                Name= "LG",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 720.00M,
                Category="SmartPhone"
            },
               new Product()
            {
                Name= "Motorolla",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 560.00M,
                Category="SmartPhone"
            },
             new Product()
            {
                Name= "Nokia",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 650.00M,
                Category="SmartPhone"

            },,
             new Product()
            {
                Name= "Salman",
                Description="This is a biggest phone company",
                ImageFile="product-1.png",
                Price= 650.00M,
                Category="SmartPhone"

            },
        };
    }
}
