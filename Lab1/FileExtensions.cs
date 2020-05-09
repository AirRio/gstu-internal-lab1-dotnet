using CsvHelper;
using System;
using System.IO;
using System.Linq;

namespace Task1
{
    public static class FileExtensions
    {
        public static Product[] GetProducts(string fileName)
        {
            try
            {
                using (var reader = new StreamReader($@"..\..\..\{fileName}"))
                {
                    using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                    {
                        csv.Configuration.RegisterClassMap<CollectionMapProducts>();
                        var records = csv.GetRecords<Product>();
                        return records.ToArray();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static Storage[] GetStorage(string fileName)
        {
            try
            {
                using (var reader = new StreamReader($@"..\..\..\{fileName}"))
                {
                    using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                    {
                        csv.Configuration.RegisterClassMap<CollectionMapStorage>();
                        var records = csv.GetRecords<Storage>();
                        return records.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
