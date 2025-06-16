using Data.API;
using Data.CodeImplementation;
using Logic.API;
using Logic.CodeImplementation;

namespace Test
{
    internal class PresetDataGeneration : IDataGenerator
    {
        public override void genrate(IDataRepository DR)
        {
            DR.AddUser(new User(0001, "Bill", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User(0002, "Anna", "Nickolson", "219 Grove St. New York"));
            DR.AddUser(new User(0003, "Hank", "White", "31 Blueberry St. New York"));
            DR.AddUser(new User(0004, "Mark", "Robert", "101 Willson St. New York"));
            DR.AddUser(new User(0005, "Bob", "Reves", "50 Colorado St. New York"));

            ICatalog c1 = new Catalog(01, "Night Table Aga", 299.99f);
            ICatalog c2 = new Catalog(02, "Night Table Panama", 269.99f);
            ICatalog c3 = new Catalog(03, "Night Table Besta", 359.99f);
            ICatalog c4 = new Catalog(04, "Wardrobe Dąb", 999.99f);
            ICatalog c5 = new Catalog(05, "Double Wardrobe Aga", 1299.99f);
            ICatalog c6 = new Catalog(06, "Desk Hawana", 699.99f);
            ICatalog c7 = new Catalog(07, "Desk Lozana", 399.99f);

            DR.AddCatalog(c1);
            DR.AddCatalog(c2);
            DR.AddCatalog(c3);
            DR.AddCatalog(c4);
            DR.AddCatalog(c5);
            DR.AddCatalog(c6);
            DR.AddCatalog(c7);

            DR.AddState(new State(1, 24, c1));
            DR.AddState(new State(2, 44, c2));
            DR.AddState(new State(3, 20, c3));
            DR.AddState(new State(4, 12, c4));
            DR.AddState(new State(5, 10, c5));
            DR.AddState(new State(6, 10, c6));
            DR.AddState(new State(7, 10, c7));

            DR.AddEvent(new Sell(1, 0001, 2));
            DR.AddEvent(new Sell(2, 0002, 1));
            DR.AddEvent(new Sell(3, 0004, 5));
            DR.AddEvent(new Supply(4, 0001, 10));
            DR.AddEvent(new Return(5, 0001, 2));
        }
    }
}
