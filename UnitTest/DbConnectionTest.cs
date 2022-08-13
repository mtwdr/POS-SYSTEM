using MySql.Data.MySqlClient;

namespace UnitTest
{
    [TestClass]
    public class DbConnectionTest //Testing Database Connection
    {
        [TestMethod]
        public void TestMethod1()
        {
            string server = "localhost"; 
            string database = "pos_system";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(constring); 


            string expected = "pos_system";
            Assert.AreEqual(expected, conn.Database.ToString());
        }
    }
}