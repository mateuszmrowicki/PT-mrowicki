using Data.API;
using Logic.CodeImplementation;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test")]

namespace Logic.API
{
    public abstract class IBusinessLogic
    {
        public abstract void SellItem(int userID, int stateID, int quantity);
        public abstract void SupplyItem(int userId, int stateId, int quantity);
        public abstract void ReturnItem(int userId, int stateId, int quantity);

        public static IBusinessLogic CreateNewLogic(IDataRepository? DR)
        {
            return new BusinessLogic(DR != null ? DR : IDataRepository.CreateNewRepository(null));
        }
    }
}
