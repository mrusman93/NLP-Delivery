using NLP.Domain.Models;

namespace NLP_Delivery_WebApplication.Abstractions.Repo
{
    public interface IStoreRepo
    {
        Task<List<Stores>> GetAllStoresAsync();
        Task<Stores> GetStoreByIdAsync(int id);
        Task<Stores> CreateStoreAsync(Stores store);
        Task<Stores> UpdateStoreAsync(Stores updatedStore);
        Task<Stores> DeleteStoreAsync(int id);
        Task<List<Addresses>> ListStoreAddressAsync(int StoreId);
        Task<Addresses> GetStoreAddressIdAsync (int StoreId, int AddressId);
        Task<Addresses> CreateStoreAddressAsync(int StoreId, Addresses Address);
        Task<Addresses> UpdateStoreAddressAsync(int StoreId, Addresses updatedAddress);
        Task<Addresses> DeleteStoreAddressAsync(int StoreId, int AddressId);

    }
}
