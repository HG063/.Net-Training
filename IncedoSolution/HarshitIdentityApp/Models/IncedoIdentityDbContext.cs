using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarshitIdentityApp.Models
{
    public class IncedoIdentityDbContext : IdentityDbContext
    {
        public IncedoIdentityDbContext(DbContextOptions<IncedoIdentityDbContext> options) : base(options)
        {

        }
    }

}
