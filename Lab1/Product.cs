using System;

namespace Task1
{
    public class Product
    {
        private Action<string> NameHandler;
        private event Action<decimal> PriceHandler;
        private string _name;
        private decimal _price;

        public string Name
        {
            get => _name;

            set
            {
                _name = value;
                Notify(_name);
            }
        }

        public decimal Price
        {
            get => _price;

            set
            {
                _price = value;
                Notify(_price);
            }
        }

        public void AddObserver(Action<string> nameHandler)
        {
            NameHandler += nameHandler;
        }

        public void AddObserver(Action<decimal> priceHandler)
        {
            PriceHandler += priceHandler;
        }

        public void RemoveObserver(Action<string> nameHandler)
        {
            NameHandler -= nameHandler;
        }

        public void RemoveObserver(Action<decimal> priceHandler)
        {
            PriceHandler -= priceHandler;
        }

        public void Notify(string key)
        {
            NameHandler?.Invoke(key);
        }

        public void Notify(decimal obj)
        {
            PriceHandler?.Invoke(obj);
        }
    }
}