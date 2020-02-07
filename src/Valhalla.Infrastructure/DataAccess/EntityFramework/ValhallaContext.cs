using Microsoft.EntityFrameworkCore;
using Valhalla.Application.Abstractions.EntityFramework;
using Valhalla.Domain.Courses;

namespace Valhalla.Infrastructure.DataAccess.EntityFramework
{
    public class ValhallaContext : DbContext, IValhallaContext
    {
        public ValhallaContext(DbContextOptions<ValhallaContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Course { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ValhallaContext).Assembly);
        }
    }
}
