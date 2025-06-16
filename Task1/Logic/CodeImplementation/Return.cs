using Data.API;

namespace Logic.CodeImplementation
{
    internal class Return : IEvent
    {
        public int StateId { get; }
        public int UserId { get; }
        public int QuantityChanged { get; set; }

        public Return(int stateID, int userID, int quantityChanged)
        {
            StateId = stateID;
            UserId = userID;
            QuantityChanged = quantityChanged;
        }
    }
}
