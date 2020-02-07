using System;

namespace Valhalla.Domain.Courses
{
    public sealed class CourseViewModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public CourseViewModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
