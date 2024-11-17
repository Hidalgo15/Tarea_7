using Microsoft.EntityFrameworkCore;

public class DetencionContext : DbContext
{
    public DbSet<Detencion> Detenciones { get; set; }
    public DetencionContext(DbContextOptions<DetencionContext> options) : base(options)
    {
    }
}