﻿using Interview.Domain.Core.Events;

namespace Interview.Domain.Core.BaseType;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly IList<IDomainEvent> domainEvents = new List<IDomainEvent>();

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void Raise(IDomainEvent @event) => domainEvents.Add(@event);

    public void Clear() => domainEvents.Clear();
}
