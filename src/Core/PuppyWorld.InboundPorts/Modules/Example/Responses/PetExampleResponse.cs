using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.InboundPorts
{
    public class PetExampleResponse
    {
        public required string Name { get; set; }

        public string? Breed { get; set; }

        public int Weight { get; set; }

        public string? Comments { get; set; }
    }
}
