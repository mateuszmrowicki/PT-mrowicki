using Data.API;
using Data.CodeImplementation;

namespace Test
{
    [TestClass]
    public class PresetDataGenerationTest
    {
        [TestMethod]
        public void TestPresetDataGeneration()
        {
            IDataRepository DR = new DataRepository(null);
            IDataGenerator DG = new PresetDataGeneration();
            DG.genrate(DR); 

            Assert.AreEqual(DR.GetUser(0001).Id, 0001);
            Assert.AreEqual(DR.GetUser(0002).FirstName, "Anna");
            Assert.AreEqual(DR.GetUser(0003).LastName, "White");
            Assert.AreEqual(DR.GetUser(0004).Address, "101 Willson St. New York");
            Assert.AreEqual(DR.GetUsersList().Count(), 5);
            DR.RemoveUser(0001);
            Assert.AreEqual(DR.GetUsersList().Count(), 4);

            Assert.AreEqual(DR.GetCatalog(01).Id, 01);
            Assert.AreEqual(DR.GetCatalog(02).Name, "Night Table Panama");
            Assert.AreEqual(DR.GetCatalog(03).Price, 359.99f);
            Assert.AreEqual(DR.GetCatalogsList().Count(), 7);
            DR.RemoveCatalog(01);
            Assert.AreEqual(DR.GetCatalogsList().Count(), 6);

            Assert.AreEqual(DR.GetState(1).ItemId, 01);
            Assert.AreEqual(DR.GetState(2).Quantity, 44);
            Assert.AreEqual(DR.GetState(3).StateId, 3);
            Assert.AreEqual(DR.GetStatesList().Count(), 7);
            DR.RemoveState(DR.GetState(1));
            Assert.AreEqual(DR.GetStatesList().Count(), 6);

            Assert.AreEqual(DR.GetEventsList().Count(), 5);
        }
    }
}
