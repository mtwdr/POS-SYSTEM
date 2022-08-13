using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Asn1.X500;
using System;

namespace UnitTest
{
    [TestClass]
    public class RandomOrderNumberTest //Testing random order number generator. 
    {
        Random rnd = new Random();

        [TestMethod]
        public void MyTestMethod()
        {
            int expected = rnd.Next(1, 9999999);

            Assert.AreNotEqual(expected, rnd.Next(1, 9999999));
        }
    }
}