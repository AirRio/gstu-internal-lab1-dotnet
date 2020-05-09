namespace Task1
{
    public class Storage
    {
        public string ProductName { get; set; }

        public string Supplier { get; set; }

        public decimal Markup { get; set; }
        
        public int ProductsAmount { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal ProductsCost => SellingPrice * ProductsAmount;

        public void UpdateName(string name)
        {
            ProductName = name;
        }

        public void UpdateSellingPrice(decimal price)
        {
            if (Markup < 15m)
            {
                SellingPrice = price + price * Markup / 100;
            }        
        }

        public override string ToString() => ($"{ProductName};{SellingPrice,6:f2};{ProductsAmount};{ProductsCost,6:f2}");
    }
}
