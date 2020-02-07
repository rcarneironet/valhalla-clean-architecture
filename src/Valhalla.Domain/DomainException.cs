using System;

namespace Valhalla.Domain
{
    public class DomainException : Exception
    {
        internal DomainException(string businessExceptionMessage)
            : base(businessExceptionMessage)
        {
        }
    }
}
