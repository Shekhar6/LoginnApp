using LoginApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Repository
{
    public interface IUserRepository
    {
        public List<UserDetails> GetUsers();
        public string RegisterUser(UserDetails user);

        public List<UserDetails> ValidateUser(LoginUser login);

    }
}
