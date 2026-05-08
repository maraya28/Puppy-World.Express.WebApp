namespace PuppyWorld.Domain
{
    public class Service
    {
        public Guid Id { get; set; }

        public ServiceType Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }
    }
}
