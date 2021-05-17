using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Areas.Identity.Data;
using Hello.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TuneIfEsport.Models;

namespace Hello.Data
{
    public class HelloContext : IdentityDbContext<HelloUser>
    {
        public HelloContext(DbContextOptions<HelloContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<Score> Scores { get; set; }








        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
