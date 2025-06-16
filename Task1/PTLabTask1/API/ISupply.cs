namespace Data.API
{
    public interface ISupply : IEvent
    {
        int StateId
        {
            get;
        }
        int UserId
        {
            get;
        }
        int QuantityChanged
        {
            get;
            set;
        }
    }
}
