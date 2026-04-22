using PuppyWorld.Domain;
using PuppyWorld.InboundPorts;

namespace PuppyWorld.Application
{
    public static class PetMapper
    {
        public static PetExample ToDomainModel(this PetExampleRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            return new PetExample
            {
                Name = request.Name,
                Breed = request.Breed,
                Weight = request.Weight,
                Comments = request.Comments
            };
        }

        public static PetExampleResponse ToResponse(this PetExample model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            return new PetExampleResponse
            {
                Name = model.Name,
                Breed = model.Breed,
                Weight = model.Weight,
                Comments = model.Comments
            };
        }
    }
}
