using System;

namespace Valhalla.Infrastructure.DataAccess.Dapper.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
