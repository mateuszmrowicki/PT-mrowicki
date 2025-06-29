using Data.API;
using Data.CodeImplementation;
using Logic.CodeImplementation;

namespace Test
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestNullEmptyGeneration()
        {
            var DR = IDataRepository.CreateNewRepository(null);
            Assert.IsNotNull(DR);
            Assert.IsTrue(DR.GetCatalogsList().Count() == 0);
            Assert.IsTrue(DR.GetEventsList().Count() == 0);
            Assert.IsTrue(DR.GetUsersList().Count() == 0);
            Assert.IsTrue(DR.GetStatesList().Count() == 0);
        }

        [TestMethod]
        public void TestCatalog()
        {
            IDataRepository DR = new DataRepository(null);
            ICatalog testCatalog = new Catalog(0, "Szafa Robert", 126.26f);
            DR.AddCatalog(testCatalog);
            Assert.AreEqual(DR.GetCatalog(0).Id, 0);
            Assert.AreEqual(DR.GetCatalog(0).Name, "Szafa Robert");
            Assert.AreEqual(DR.GetCatalog(0).Price, 126.26f);
            Assert.IsTrue(DR.GetCatalogsList().Count() == 1);
            DR.RemoveCatalog(0);
            Assert.IsTrue(DR.GetCatalogsList().Count() == 0);
        }
        [TestMethod]
        public void TestUser()
        {
            IDataRepository DR = new DataRepository(null);
            IUser user = new User(0001, "Bill", "Nickolson", "219 Grove St. New York");
            DR.AddUser(user);
            Assert.AreEqual(DR.GetUser(0001).Id, 0001);
            Assert.AreEqual(DR.GetUser(0001).FirstName, "Bill");
            Assert.AreEqual(DR.GetUser(0001).LastName, "Nickolson");
            Assert.AreEqual(DR.GetUser(0001).Address, "219 Grove St. New York");
            Assert.IsTrue(DR.GetUsersList().Count() == 1);
            DR.RemoveUser(0001);
            Assert.IsTrue(DR.GetUsersList().Count() == 0);
        }

        [TestMethod]
        public void TestStateMethods()
        {
            IDataRepository DR = new DataRepository(null);
            ICatalog t_catalog = new Catalog(002, "Table", 199.99f);
            IState t_state = new State(1, 12, t_catalog);
            DR.AddState(t_state);

            Assert.IsNotNull(DR.GetState(1));
            try
            {
                Assert.IsNull(DR.GetState(121));
            }
            catch { };
            Assert.IsTrue(DR.GetStatesList().Count() == 1);

            DR.RemoveState(DR.GetState(1));

            Assert.IsTrue(DR.GetStatesList().Count() == 0);
            try
            {
                Assert.IsNull(DR.GetState(1));
            }
            catch { };
        }

        [TestMethod]
        public void TestEventMethods()
        {
            IDataRepository DR = new DataRepository(null);
            ICatalog t_catalog = new Catalog(002, "Table", 199.99f);
            IState t_state = new State(1, 12, t_catalog);
            IUser t_user = new User(0004, "Rob", "Reeves", "50 Rain St. New Mexico");
            IEvent t_event = new Sell(1, 0004, 3);
            IEvent t_event2 = new Sell(3, 0005, 3);
            DR.AddEvent(t_event);

            Assert.IsTrue(DR.GetEventsList().Count() == 1);
            DR.RemoveEvent(t_event2);
            Assert.IsTrue(DR.GetEventsList().Count() == 1);
            DR.RemoveEvent(t_event);
            Assert.IsTrue(DR.GetEventsList().Count() == 0);

        }

        [TestMethod]
        public void TestQuantityMethod()
        {
            IDataRepository DR = new DataRepository(null);
            ICatalog t_catalog = new Catalog(002, "Table", 199.99f);
            IState t_state = new State(1, 12, t_catalog);
            DR.AddCatalog(t_catalog);
            DR.AddState(t_state);
            DR.ChangeQuantity(1, 5);
            Assert.AreEqual(DR.GetState(1).Quantity, 17);
        }
    }
}