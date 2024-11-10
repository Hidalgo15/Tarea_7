using Microsoft.EntityFrameworkCore;

public class DetencionContext : DbContext
{
    public DetencionContext(DbContextOptions<DetencionContext> options)
        : base(options)
    {
    }

    public DbSet<Detencion> Detenciones { get; set; }
}
