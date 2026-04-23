
namespace PuppyWorld.InboundPorts
{
    public interface IExampleApplication
    {
        public Task AddPetExample(PetExampleRequest request);

        public Task<IEnumerable<PetExampleResponse>> GetPets();
    }
}
