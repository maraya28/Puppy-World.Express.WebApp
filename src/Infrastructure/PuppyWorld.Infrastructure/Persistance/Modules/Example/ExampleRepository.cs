using PuppyWorld.Domain;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Infrastructure.Persistance
{
    public class ExampleRepository : IExampleRepository
    {
        public async Task<List<PetExample>> GetPets()
        {
            var result = new List<PetExample>()
            {
                new PetExample() { Name ="Thor", Breed = "Yorkshire" }
            };
            return await Task.FromResult(result);
        }
    }
}