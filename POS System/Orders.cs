using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{

    internal class Orders
    {
        public int OrderNumber
        {
            get { return OrderNumber; }
            set { OrderNumber = value; }
        }

        public string OrderType
        {
            get { return OrderType; }
            set { OrderType = value; }
        }

        public string LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string Company
        {
            get { return Company; }
            set { Company = value; }
        }

        public string Address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string Telephone
        {
            get { return Telephone; }
            set { Telephone = value; }
        }

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string Products
        {
            get { return Products; }
            set { Products = value; }
        }

        public string Prices
        {
            get { return Prices; }
            set { Prices = value; }
        }

        public string Quantities
        {
            get { return Quantities; }
            set { Quantities = value; }
        }

        public string Total
        {
            get { return Total; }
            set { Total = value; }
        }

    }
}
