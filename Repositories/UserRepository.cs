using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {

        public static User Get(string username, string password)
        {

            var users = new List<User>
            {
                new() { ID = 1, UserName = "batman", Password = "batman", Role = "admin" },
                new() { ID = 2, UserName = "robin", Password = "robin", Role = "common" }
            };



            return users
                .FirstOrDefault(x =>
                string.Equals(x.UserName,username,StringComparison.CurrentCultureIgnoreCase) 
                && x.Password == password.ToLower());

        }
    }
}
    
