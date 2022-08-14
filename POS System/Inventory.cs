using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    internal class Inventory
    {
        public int Sku
        {
            get { return Sku; }
            set { Sku = value; }
        }
        public int Barcode
        {
            get { return Barcode; }
            set { Barcode = value; }
        }

        public string ProductName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }

        public double Price
        {
            get { return Price; }
            set { Price = value; }
        }

        public int Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public string Location
        {
            get { return Location; }
            set { Location = value; }
        }
    }
}
