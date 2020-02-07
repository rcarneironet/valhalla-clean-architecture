namespace Valhalla.Domain.Courses
{
    public sealed class CourseExceptions : DomainException
    {
        internal CourseExceptions(string businessExceptionMessage)
            : base(businessExceptionMessage)
        { }
    }
}
