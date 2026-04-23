using PuppyWorld.Domain;

namespace PuppyWorld.OutboundPorts
{
    public interface IExampleRepository
    {
        public Task AddPetExample(PetExample model);

        public Task<IEnumerable<PetExample>> GetPets();
    }
}
