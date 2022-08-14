using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    internal class Users
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public int LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public int Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public int UserType
        {
            get { return UserType; }
            set { UserType = value; }
        }

    }
}
