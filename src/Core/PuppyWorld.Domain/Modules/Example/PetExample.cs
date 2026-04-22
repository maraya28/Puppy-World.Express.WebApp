using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.Domain
{
    public class PetExample
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Breed { get; set; }

        public int Weight { get; set; }

        public string? Comments { get; set; }
    }
}
