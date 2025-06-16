using Data.API;

namespace Logic.CodeImplementation
{
    internal class Supply : ISupply
    {
        public int StateId { 
            get; set;
        }
        public int UserId
        {
            get; set;
        }
        public int QuantityChanged 
        { 
            get; set; 
        }

        public Supply(int stateId, int userId, int quantityChanged)
        {
            StateId = stateId;
            UserId = userId;
            QuantityChanged = quantityChanged;
        }
    }
}
