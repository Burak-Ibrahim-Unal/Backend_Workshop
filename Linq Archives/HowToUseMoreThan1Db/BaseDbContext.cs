using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public abstract class BaseDbContext : DbContext
    {

        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public BaseDbContext()
        {


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
