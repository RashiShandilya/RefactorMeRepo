using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RefactorMe.Tests
{
    [TestClass]
    public class Product
    {
        [TestMethod]
        public void ProductData_Test()
        {
            var result = ProductDataConsolidator.Get();

            Assert.IsNotNull(result);
        }

       
    }
}
