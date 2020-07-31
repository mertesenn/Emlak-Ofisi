using Emlak_Ofisi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emlak_Ofisi.Context
{
    public class EmlakDBContext : DbContext
    {
        public EmlakDBContext(DbContextOptions<EmlakDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Advert> Adverts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
