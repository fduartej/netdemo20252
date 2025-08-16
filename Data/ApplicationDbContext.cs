using Microsoft.EntityFrameworkCore;
using netdemo20252.Models;

namespace netdemo20252.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {

    }

    public DbSet<Instrument> DSInstruments { get; set; }
}