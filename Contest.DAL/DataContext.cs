using Contest.BizLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace Contest.DAL;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> opts):base(opts)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
