using AppFacturas.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AppFacturas.DataAcces
{
    public class AppFacturasDBContext: DbContext
    {
        public AppFacturasDBContext(DbContextOptions<AppFacturasDBContext> options): base(options) { }

        public DbSet<User>? Users { get; set; }
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<Enterprise>? Enterprises { get; set; }
        public DbSet<LineBill>? LineBills { get; set; }

    }

}
