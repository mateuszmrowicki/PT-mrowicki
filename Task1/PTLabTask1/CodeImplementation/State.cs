using Data.API;

namespace Data.CodeImplementation
{
    internal class State : IState
    {
        private ICatalog Catalog;
        public State(int stateId, int quantity, ICatalog catalog)
        {
            StateId = stateId;
            Quantity = quantity;
            Catalog = catalog;
        }

        public int StateId { 
            get;
            set;
        }
        public int Quantity { 
            get; 
            set; 
        }
        public int ItemId => Catalog.Id;
    }
}
