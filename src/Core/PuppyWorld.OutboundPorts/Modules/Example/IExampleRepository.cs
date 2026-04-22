using PuppyWorld.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.OutboundPorts
{
    public interface IExampleRepository
    {
        public Task<List<PetExample>> GetPets();
    }
}
