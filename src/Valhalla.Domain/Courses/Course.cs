using System;

namespace Valhalla.Domain.Courses
{
    public sealed class Course : IEntity
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        public void Register(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            Created = DateTime.UtcNow;
        }

        public void ChangeName(CourseViewModel course)
        {
            if (string.IsNullOrEmpty(course.Name))
            {
                throw new CourseExceptions($"Course name cannot be null or empty!");
            }

            Name = course.Name;
            Updated = DateTime.UtcNow;
        }
    }
}
