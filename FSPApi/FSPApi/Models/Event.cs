using FSPApi.Interfaces;

namespace FSPApi.Models
{
    public class Event : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool? IsConfirmed { get; set; }
        public bool? IsEnd { get; set; }
        public virtual ICollection<Athlete>? Athletes { get; set; }
    }
}
