namespace PuppyWorld.Domain
{
    public class Owner
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }

        public required string PhoneNumber { get; set; }

        public List<OwnerContact>? Contacts { get; set; }
    }
}
