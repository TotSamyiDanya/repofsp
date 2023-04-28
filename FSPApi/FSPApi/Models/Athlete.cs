using FSPApi.Interfaces;
using FSPApi.Models.Documents;

namespace FSPApi.Models
{
    public class Athlete : IEntity, IUser
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
        public int Rating { get; set; }
        public string? Pasport { get; set; }
    }
}
