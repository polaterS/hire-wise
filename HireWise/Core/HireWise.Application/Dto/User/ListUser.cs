namespace HireWise.Application.Dto.User
{
    public class ListUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
}