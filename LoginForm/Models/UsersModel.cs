namespace LoginForm.Models
{
    public class UsersModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLogged { get; set; }
    }
}
