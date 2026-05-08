namespace PuppyWorld.Domain
{
    public class Pet
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Breed { get; set; }

        public int Weight { get; set; }

        public string? Comments { get; set; }

        public PetStatus Status { get; set; }

        public required Owner Owner { get; set; }
    }
}
