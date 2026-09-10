using Microsoft.EntityFrameworkCore;

namespace CodeFirst_EFCore.Models;

public class NBADbContext : DbContext
{
    public NBADbContext()
    {
        
    }

    public NBADbContext(DbContextOptions<NBADbContext> options) : base(options) {}

    public DbSet<Team> Teams {get; set;}

    public DbSet<Player> Players {get; set;}
    
}

