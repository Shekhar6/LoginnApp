using LoginApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace LoginApp.Repository
{
    public class UserRepo : IUserRepository
    {
        private readonly UserContextDb db;

        public UserRepo(UserContextDb _db)
        {
            db = _db;
        }
        public List<UserDetails> GetUsers()
        {
            return db.UserDetails.ToList();
        }

        public string RegisterUser(UserDetails user)
        {
            db.UserDetails.Add(user);
            db.SaveChanges();
            return "Registered Successfully";
        }

        public List<UserDetails> ValidateUser(LoginUser login)
        {
            List<UserDetails> result = db.UserDetails.Where(temp => temp.Username == login.UserName && temp.Password == login.Password).ToList();
            return result;
        }
    }
}
