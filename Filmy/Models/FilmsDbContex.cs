using Microsoft.EntityFrameworkCore;
namespace Filmy.Models
{
    public class FilmsDbContex : DbContext
    {
        public FilmsDbContex(DbContextOptions<FilmsDbContex> options) :
       base(options)
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}
