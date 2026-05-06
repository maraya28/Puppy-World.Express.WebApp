using PuppyWorld.InboundPorts;
using Refit;

namespace PuppyWorld.Application.Modules.Example
{
    public interface IPetExampleClient
    {
        [Get("/example/petsExample")]
        Task<List<PetExampleResponse>> GetPetsExample();
    }
}
