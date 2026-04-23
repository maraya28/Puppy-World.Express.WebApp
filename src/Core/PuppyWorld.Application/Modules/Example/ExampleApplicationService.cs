using PuppyWorld.InboundPorts;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Application
{
    public class ExampleApplicationService(IExampleRepository exampleRepository) : IExampleApplication
    {
        public async Task AddPetExample(PetExampleRequest request)
        {
            await exampleRepository.AddPetExample(request.ToDomainModel());
        }

        public async Task<IEnumerable<PetExampleResponse>> GetPets()
        {
            var pets = await exampleRepository.GetPets();
            var result = pets.Select(_ => _.ToResponse());
            return result;
        }
    }
}