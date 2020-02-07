using System;

namespace Valhalla.Domain
{
    internal interface IEntity
    {
        Guid Id { get; }
        DateTime Created { get; }
        DateTime Updated { get; }
    }
}
