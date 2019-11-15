using Microsoft.EntityFrameworkCore;
using TrackingApp.API.models;


namespace TrackingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
        

    }
}