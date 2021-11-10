using LoginApp.Model;
using LoginApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LoginApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _db;

        public UserController(IUserRepository db)
        {
            _db = db;
        }

        [HttpGet]
        public List<UserDetails> Get()
        {
            return _db.GetUsers();
        }
        [HttpPost]
        public List<UserDetails> post(LoginUser user)
        {
            return _db.ValidateUser(user);
        }
    }
}
