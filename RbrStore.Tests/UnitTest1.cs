using Microsoft.VisualStudio.TestTools.UnitTesting;
using RbrStore.Domain.StoreContext.Entities;

namespace RbrStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Sandinelson", 
                "Stanley",
                "12345678911",
                "stanley@microloc.com.br",
                "199999999",
                "Estrada dos Bandeirantes, 2871");

            var order = new Order(c);
            //order.Items.
            
        }


    }
}
