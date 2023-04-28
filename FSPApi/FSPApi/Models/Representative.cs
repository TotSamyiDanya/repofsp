using FSPApi.Interfaces;

namespace FSPApi.Models
{
    public class Representative : IEntity, IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}
