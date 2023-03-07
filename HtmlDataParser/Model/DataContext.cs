using Microsoft.EntityFrameworkCore;


namespace HtmlDataParser.Model
{
    public class DataContext : DbContext
    {
        public DbSet<DataContent> Content { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataContent>()
               .HasKey(c => c.DealNumber);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=HtmlDataParser;Persist Security Info=True;TrustServerCertificate=True;User ID=virto;Password=virto;Connect Timeout=30");
        }
    }
}

