namespace FSPApi.Models
{
    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<Athlete>? Athletes { get; set; }
    }
}
