using PostgreApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostgreApp.Repository
{
    public interface IStoreRepository
    {
        Task<List<Store>> GetStoresAsync();
        Task  InsertStore(Store store);
    }
}
