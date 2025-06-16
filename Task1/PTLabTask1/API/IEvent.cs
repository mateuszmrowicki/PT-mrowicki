
namespace Data.API
{
    public interface IEvent
    {
        int StateId { 
            get; 
        }
        int UserId { 
            get; 
        }
        int QuantityChanged { 
            get;
            set;
        }
    }
}
