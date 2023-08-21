using Microsoft.EntityFrameworkCore;


public class ApplicationContext : DbContext
{
    public DbSet<Users> Users => Set<Users>();
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseMySql(
                "server=localhost;user=user;password=1234qwer;database=FirstApp;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );


    }
}