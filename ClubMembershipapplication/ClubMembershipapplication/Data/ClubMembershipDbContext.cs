using ClubMembershipapplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembershipapplication.Data
{
    public class ClubMembershipDbContext: DbContext
    {
        public ClubMembershipDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ClubMembershipDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True; Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
