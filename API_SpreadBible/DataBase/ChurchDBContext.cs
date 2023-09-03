using API_SpreadBible.Models;
using Microsoft.EntityFrameworkCore;

namespace API_SpreadBible.DataBase
{
    public class ChurchDBContext : DbContext
    {
        public ChurchDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Church> Churches { get; set; }
         
    }
}
