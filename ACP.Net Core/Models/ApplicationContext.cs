using ACP.Net_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFDataApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated(); // создаем базу данных при первом обращении
        }
    }
}