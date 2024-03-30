using NLP.Domain.Models;

namespace NLP_Delivery_WebApplication.Abstractions.Repo
{
    public interface IStoreRepo
    {
        List<Stores> GetAllStores();
        Stores GetStoreById (int id);
        Stores CreateStore(Stores store);
        Stores UpdateStore(Stores updatedStore);
        Stores DeleteStore(int id);
        List<Addresses> ListStoreAddress(int StoreID);

    }
}
