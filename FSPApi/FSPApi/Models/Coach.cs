using FSPApi.Interfaces;
using FSPApi.Models.Documents;

namespace FSPApi.Models
{
    public class Coach : IEntity, IUser
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Pasport { get; set; }
    }
}
