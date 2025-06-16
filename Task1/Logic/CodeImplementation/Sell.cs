using Data.API;

namespace Logic.CodeImplementation
{
    internal class Sell : ISell
    {
        public int StateId { get; }
        public int UserId { get; }
        public int QuantityChanged { get; set; }

        public Sell(int stateID, int userID, int quantityChanged)
        {
            StateId = stateID;
            UserId = userID;
            QuantityChanged = quantityChanged;
        }
    }
}
