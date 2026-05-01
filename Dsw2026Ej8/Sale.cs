using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        private decimal _price;
        private int _quantity;

        public void SetPrice(decimal price)
        {
            _price = price;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public virtual decimal CalculateTotal()
        {
            return _price * _quantity;
        }
    }
}
