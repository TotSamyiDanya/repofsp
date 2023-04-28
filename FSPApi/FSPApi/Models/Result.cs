namespace FSPApi.Models
{
    public class Result
    {
        public Guid Id { get; set; }
        public virtual Athlete Athlete { get; set; }
        public virtual Event Event { get; set; }
        public int Score { get; set; }
    }
}
