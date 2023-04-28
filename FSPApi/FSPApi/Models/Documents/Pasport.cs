namespace FSPApi.Models.Documents
{
    public class Pasport
    {
        public string Series { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public virtual Athlete Athlete { get; set; }
    }
}
