namespace FSPApi.Interfaces
{
    public interface IUser
    {
        string Login { get; set; }
        string Password { get; set; }
        string Image { get; set; }
    }
}
