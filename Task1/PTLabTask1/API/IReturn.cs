namespace Data.API
{
    public interface IReturn : IEvent
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
