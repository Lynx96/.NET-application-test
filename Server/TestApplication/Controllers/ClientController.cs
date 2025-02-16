using Microsoft.AspNetCore.Mvc;
using ProductApi.models;
using TestApplication.Services.Interfaces;

namespace TestApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ClientCreateDto clientDto)
        {
             var client = new Client
            {
                Name = clientDto.Name,
                Email = clientDto.Email,
                PhoneNumber = clientDto.PhoneNumber
            };            
            await _clientService.CreateClientAsync(client);
            return CreatedAtAction(nameof(GetById), new { id = client.Id }, client);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Client client)
        {
            if (id != client.Id) return BadRequest();
            await _clientService.UpdateClientAsync(client);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _clientService.DeleteClientAsync(id);
            return NoContent();
        }
    }

}