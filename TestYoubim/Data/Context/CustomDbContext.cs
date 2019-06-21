using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestYoubim.Model;

namespace TestYoubim.Data.Context
{
    public class CustomDbContext: DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
        {

        }

        public DbSet<Node> Node { get; set; }
        public DbSet<User> User { get; set; }

    }
}
