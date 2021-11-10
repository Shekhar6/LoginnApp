using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Model
{
    public class UserContextDb:DbContext
    {
        public UserContextDb(DbContextOptions<UserContextDb> options) : base(options)
        {

        }
        
        public DbSet<UserDetails> UserDetails {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JNETLAP311\SQLEXP2014;Database=UserLogin;integrated security=True;");
        }
    }
}
