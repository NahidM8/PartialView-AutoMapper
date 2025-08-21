using Microsoft.EntityFrameworkCore;
using PartialView.Models;

namespace PartialView.Data
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
