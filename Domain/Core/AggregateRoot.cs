﻿// using CleanArchitectureWorkshop.Domain.Core.Ids;

namespace CleanArchitectureWorkshop.Domain.Core;

public abstract class AggregateRoot<TId> : Entity<TId>
    where TId : ValueObject
{
    protected AggregateRoot(TId id) : base(id)
    {
    }

#pragma warning disable CS8618
    protected AggregateRoot()
    {
    }
#pragma warning restore CS8618
}