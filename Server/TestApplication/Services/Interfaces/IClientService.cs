using System.Collections.Generic;
using System.Threading.Tasks;
using ProductApi.models;

namespace TestApplication.Services.Interfaces {
    public interface IClientService { 
        Task<List<Client>> GetAllClientsAsync();
        Task<Client?> GetClientByIdAsync(int id);
        Task CreateClientAsync(Client client );
        Task UpdateClientAsync(Client client );
        Task DeleteClientAsync(int id);

    }

}
