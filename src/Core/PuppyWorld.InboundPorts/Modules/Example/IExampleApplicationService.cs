using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.InboundPorts
{
    public interface IExampleApplicationService
    {
        public Task<IEnumerable<PetExampleResponse>> GetPets();
    }
}
