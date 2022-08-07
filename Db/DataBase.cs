using E_Yoklama.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Yoklama.Db
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Check> Checks { get; set; }
    }
}
