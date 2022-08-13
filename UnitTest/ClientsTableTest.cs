using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;

namespace UnitTest
{
    [TestClass]
    public class ClientsTableTest //Testing fetching data from clients table
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Boolean expected = false;

            string server = "localhost";
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "select * from clients";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                expected = true;
            }

            Assert.AreEqual(true, expected);
        }
    }
}