using Microsoft.AspNetCore.Mvc;
using PuppyWorld.InboundPorts;

namespace PuppyWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController(IExampleApplicationService exampleApplicationService) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<PetExampleResponse>> GetPets()
        {
            return await exampleApplicationService.GetPets();
        }
    }
}
