using FragranceStoreAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FragranceStoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        

        public DbSet<Fragrance> fragrances { get; set; }
        // public DbSet<FragranceReviews> Reviews { get; set; }
    }
}
