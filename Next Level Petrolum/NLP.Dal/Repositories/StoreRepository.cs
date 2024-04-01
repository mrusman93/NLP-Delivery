using Microsoft.EntityFrameworkCore;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.Abstractions.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace NLP.Dal.Repositories
{
    public class StoreRepository : IStoreRepo
    {

        private readonly DataContext _dataContext;

        public StoreRepository(DataContext dataContext) 
        {
            _dataContext = dataContext; 
        }
        public async Task<Addresses?> CreateStoreAddressAsync(int StoreId, Addresses Address)
        {
            var store = await _dataContext.Store.Include(s => s.Address)
                .FirstOrDefaultAsync(s => s.StoreID == StoreId);

            store.Address.Add(Address);

            await _dataContext.SaveChangesAsync();
            return Address;
        }

        public async Task<Stores> CreateStoreAsync(Stores store)
        {
            _dataContext.Store.Add(store);
            await _dataContext.SaveChangesAsync();
            return store;
        }

        public async Task<Addresses?> DeleteStoreAddressAsync(int StoreId, int AddressId)
        {
            var address = await _dataContext.Address.SingleOrDefaultAsync(a => a.AddressID == AddressId && a.StoreID == StoreId);

            if (address == null)
                return null;

            _dataContext.Address.Remove(address);
            await _dataContext.SaveChangesAsync();
            return address;
        }

        public async Task<Stores?> DeleteStoreAsync(int id)
        {
            var store = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);

            if (store == null)
                return null;

            _dataContext.Store.Remove(store);
            await _dataContext.SaveChangesAsync();
            return store;

        }

        public async Task<List<Stores>> GetAllStoresAsync()
        {
            return await _dataContext.Store.ToListAsync();
        }

        public async Task<Addresses?> GetStoreAddressIdAsync(int StoreId, int AddressId)
        {
            var address = await _dataContext.Address.FirstOrDefaultAsync(a => a.AddressID == AddressId && a.StoreID == StoreId);

            if (address == null)
                return null;

            return address;
        }

        public async Task<Stores> GetStoreByIdAsync(int id)
        {
            var stores = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);

            if (stores == null)
                return null;

            return stores;
        }

        public async Task<List<Addresses>> ListStoreAddressAsync(int StoreId)
        {
            return await _dataContext.Address.Where(a => a.StoreID == StoreId).ToListAsync();
        }

        public async Task<Addresses> UpdateStoreAddressAsync(int StoreId, Addresses updatedAddress)
        {
            _dataContext.Address.Update(updatedAddress);
            await _dataContext.SaveChangesAsync();

            return updatedAddress;
        }

        public async Task<Stores> UpdateStoreAsync(Stores updatedStore)
        {
            _dataContext.Store.Update(updatedStore);
            await _dataContext.SaveChangesAsync();

            return updatedStore;
        }
    }
}
