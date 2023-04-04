using EF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=MasterPassword;Host=localhost;Port=5432;Database=CarApp;");
        }
    }

}
