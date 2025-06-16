using Data.API;
using Logic.API;
using Data.CodeImplementation;
using Logic.CodeImplementation;

namespace Test
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void TestSellMethod()
        {
        var DR = IDataRepository.CreateNewRepository(null);
        var logicDR = IBusinessLogic.CreateNewLogic(DR);
        DR.AddUser(new User(0001, "Bill", "Nickolson", "219 Grove St. New York"));
        ICatalog c1 = new Catalog(01, "Night Table Aga", 299.99f);
        DR.AddCatalog(c1);
        DR.AddState(new State(1, 24, c1));
        logicDR.SellItem(0001, 1, 2);
        Assert.AreEqual(DR.GetState(1).Quantity, 22);
        }

        [TestMethod]
        public void TestSupplyMethod()
        {
            var DR = IDataRepository.CreateNewRepository(null);
            var logicDR = IBusinessLogic.CreateNewLogic(DR);
            DR.AddUser(new User(0001, "Bill", "Nickolson", "219 Grove St. New York"));
            ICatalog c1 = new Catalog(01, "Night Table Aga", 299.99f);
            DR.AddCatalog(c1);
            DR.AddState(new State(1, 24, c1));
            logicDR.SupplyItem(0001, 1, 20);
            Assert.AreEqual(DR.GetState(1).Quantity, 44);
        }

        [TestMethod]
        public void TestReturnMethod()
        {
            var DR = IDataRepository.CreateNewRepository(null);
            var logicDR = IBusinessLogic.CreateNewLogic(DR);
            DR.AddUser(new User(0001, "Bill", "Nickolson", "219 Grove St. New York"));
            ICatalog c1 = new Catalog(01, "Night Table Aga", 299.99f);
            DR.AddCatalog(c1);
            DR.AddState(new State(1, 24, c1));
            logicDR.SellItem(0001, 1, 2);
            logicDR.ReturnItem(0001, 1, 1);

            Assert.AreEqual(DR.GetState(1).Quantity, 23);

            Assert.ThrowsException<Exception>(() => logicDR.ReturnItem(0001, 2, 1));
        }
    }
}
