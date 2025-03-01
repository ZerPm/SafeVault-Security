namespace SafeVault.Web.Services
{
    public class UserService
    {
        public bool CreateUser(string username, string password)
        {
            var hashedPassword = PasswordHasher.Hash(password);
            // Aquí se guardaría en la base de datos
            return true;
        }
    }
}
