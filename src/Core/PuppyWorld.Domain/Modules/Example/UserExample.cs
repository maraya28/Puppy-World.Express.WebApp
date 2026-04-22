using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyWorld.Domain.Modules.Example
{
    public class UserExample
    {
        public required string Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }
    }
}
