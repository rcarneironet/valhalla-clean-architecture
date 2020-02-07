using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Valhalla.Application.Repositories;
using Valhalla.Domain.Courses;

namespace Valhalla.Infrastructure.DataAccess.Dapper.Repositories
{
    public class CourseReadOnlyRepository : ICourseReadOnlyRepository
    {
        //just for test purpose, consider using DI for this
        private readonly string connectionString = @"Data Source=OFFICEWS;Initial Catalog=ValhallaDatabase;Integrated Security=True";

        public async Task<IEnumerable<Course>> List()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string accountSQL = @"SELECT * FROM [dbo].[Course] with (NOLOCK)";
                return await db.QueryAsync<Course>(accountSQL);
            }
        }
    }
}
