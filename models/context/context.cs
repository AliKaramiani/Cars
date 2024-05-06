
using Microsoft.EntityFrameworkCore;

public class Context :DbContext
{
    public DbSet<Toyota> Tbl_Toyota { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=CarDb;Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }
}