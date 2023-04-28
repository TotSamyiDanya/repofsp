using FSPApi.Interfaces;

namespace FSPApi.Models
{
    public class Admin : IEntity
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        // будут методы
    }
}
