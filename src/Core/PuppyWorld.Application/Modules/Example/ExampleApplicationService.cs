using PuppyWorld.InboundPorts;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Application
{
    public class ExampleApplicationService(IExampleRepository exampleRepository) : IExampleApplicationService
    {
        public async Task<IEnumerable<PetExampleResponse>> GetPets()
        {
            var pets = await exampleRepository.GetPets();
            var result = pets.Select(_ => _.ToResponse());
            return result;
        }
    }
}
