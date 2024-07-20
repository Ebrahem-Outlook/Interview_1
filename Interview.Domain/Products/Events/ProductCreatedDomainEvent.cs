using Interview.Domain.Core.Events;

namespace Interview.Domain.Products.Events;

public sealed record ProductCreatedDomainEvent(
    Guid ProducdId, 
    string Name, 
    string Description, 
    decimal Price, 
    int Stock,
    DateTime CreatedOn) : DomainEvent;
