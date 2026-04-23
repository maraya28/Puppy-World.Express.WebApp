using Microsoft.EntityFrameworkCore;
using PuppyWorld.Domain;
using PuppyWorld.OutboundPorts;

namespace PuppyWorld.Infrastructure.Persistance
{
    internal class ExampleRepository(PuppyWorldDbContext puppyWorldDb) : IExampleRepository
    {
        public async Task AddPetExample(PetExample model)
        {
            await puppyWorldDb.AddAsync(model);
            await puppyWorldDb.SaveChangesAsync();
        }

        public async Task<IEnumerable<PetExample>> GetPets()
        {
            var result = await puppyWorldDb.PetExamples.ToListAsync();
            return result;
        }
    }
}