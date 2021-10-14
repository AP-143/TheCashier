using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCashier
{
    internal class Item
    {
        private int id;
        public int title { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int subTotal { get; set; }

        private string type;
        public Item(int id, string title, int quantity, string type, double price)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.type = type;
            this.price = (int)price;
            this.subTotal = 0;
        }
        public string getTitle()
        {
            return title;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public string getType()
        {
            return type;
        }
        public double getPrice()
        {
            return price;
        }
        public double getSubTotal()
        {
            subTotal = price * quantity;
            return subTotal;
        }

    }
