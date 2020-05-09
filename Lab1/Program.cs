using System;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            const string fileProduct = "Products.csv";
            const string fileStorage = "Storage.csv";
            Product[] products = FileExtensions.GetProducts(fileProduct);

            Storage[] storages = FileExtensions.GetStorage(fileStorage);

            products[0].AddObserver(storages[0].UpdateName);
            products[0].AddObserver(storages[0].UpdateSellingPrice);

            products[0].AddObserver(storages[3].UpdateName);
            products[0].AddObserver(storages[3].UpdateSellingPrice);

            products[1].AddObserver(storages[1].UpdateName);
            products[1].AddObserver(storages[1].UpdateSellingPrice);

            products[2].AddObserver(storages[2].UpdateName);
            products[2].AddObserver(storages[2].UpdateSellingPrice);

            foreach (var storage in storages)
            {
                Console.WriteLine(storage);
            }

            Console.WriteLine("____________________________________");

            products[0].Name = "Table";
            products[0].Price -= 1.55m;

            foreach (var storage in storages)
            {
                Console.WriteLine(storage);
            }
        }
    }
}
