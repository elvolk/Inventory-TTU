using System;
using InventoryBook.Logic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace InventoryBook.Tests
{
    [TestClass]
    public class InventoryItemTest
    {
        private InventoryItem i;
        [TestInitialize]
        public void Init()
        {
            i = new InventoryItem();
        }
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(i);
        }
    }
}
