using Microsoft.EntityFrameworkCore;

namespace Valhalla.Infrastructure.DataAccess.EntityFramework
{
    public class ValhallaContextFactory : DesignTimeDbContextFactoryBase<ValhallaContext>
    {
        protected override ValhallaContext CreateNewInstance(DbContextOptions<ValhallaContext> options)
        {
            return new ValhallaContext(options);
        }
    }
}
