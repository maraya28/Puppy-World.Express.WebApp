namespace PuppyWorld.Domain.Modules.Visits
{
    public class Visit
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }

        public string? Notes { get; set; }

        public required List<VisitLine> Lines { get; set; }
    }
}
