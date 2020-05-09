using CsvHelper.Configuration;

namespace Task1
{
    public class CollectionMapStorage : ClassMap<Storage>
    {
        public CollectionMapStorage()
        {
            Map(m => m.ProductName).Name(nameof(Storage.ProductName));
            Map(m => m.Supplier).Name(nameof(Storage.Supplier));
            Map(m => m.Markup).Name(nameof(Storage.Markup));
            Map(m => m.SellingPrice).Name(nameof(Storage.SellingPrice));
            Map(m => m.ProductsAmount).Name(nameof(Storage.ProductsAmount));
        }
    }
}
