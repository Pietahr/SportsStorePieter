using Microsoft.EntityFrameworkCore;
using SportsStorePieter.Models;

namespace SportsStorePieter.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=.\SQLEXPRESS;Database=SportsStorePieter;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        
    }
}
