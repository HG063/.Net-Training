using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HarshitSecurityAppDBGeneration
{
    public class IncedoIdentityDbContext : IdentityDbContext
    {
        public IncedoIdentityDbContext(DbContextOptions<IncedoIdentityDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
