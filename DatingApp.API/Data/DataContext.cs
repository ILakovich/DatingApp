
using DatingApp.API.Models;
using DatingApp.API.wwwroot.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.wwwroot.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
            
        
    }
}