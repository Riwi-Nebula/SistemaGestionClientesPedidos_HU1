using Microsoft.EntityFrameworkCore;

namespace System.Infrastructure.Data;

public class AppDbContext : DbContext
{
    // DbSet por cada Modelo
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}