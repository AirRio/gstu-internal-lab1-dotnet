using CsvHelper.Configuration;

namespace Task1
{
    public class CollectionMapProducts : ClassMap<Product>
    {
        public CollectionMapProducts()
        {
            Map(m => m.Name).Name(nameof(Product.Name));
            Map(m => m.Price).Name(nameof(Product.Price));
        }
    }
}
