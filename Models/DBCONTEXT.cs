using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SIMPLE_LOGIN_SIGNUP_API.Entities;

namespace SIMPLE_LOGIN_SIGNUP_API.Models
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions options) : base(options) { }
        DbSet<User> users
        {
            get;
            set;
        }
    }
}
