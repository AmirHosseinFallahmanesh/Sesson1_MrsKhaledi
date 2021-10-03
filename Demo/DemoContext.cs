using Microsoft.EntityFrameworkCore;

namespace Demo
{
    public class DemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DemoUni;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Dorm> Dorms { get; set; }

    }
}
