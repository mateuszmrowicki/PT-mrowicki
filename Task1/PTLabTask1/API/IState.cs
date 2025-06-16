
namespace Data.API
{
    public interface IState
    {
        int ItemId { 
            get; 
        }
        int StateId {
            get;
            set;
        }
        int Quantity { 
            get; 
            set; 
        }
    }
}
