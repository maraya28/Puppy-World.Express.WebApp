using Microsoft.AspNetCore.Mvc;
using PuppyWorld.InboundPorts;

namespace PuppyWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController(IExampleApplication exampleApplication) : ControllerBase
    {
        [HttpPost("AddPetExample")]
        public async Task AddPetExample(PetExampleRequest request)
        {
            await exampleApplication.AddPetExample(request);
        }

        [HttpGet("PetsExample")]
        public async Task<IEnumerable<PetExampleResponse>> GetPets()
        {
            return await exampleApplication.GetPets();
        }
    }
}
