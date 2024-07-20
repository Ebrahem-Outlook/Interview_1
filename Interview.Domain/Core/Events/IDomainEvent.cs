using MediatR;

namespace Interview.Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }
    DateTime OccuerOn { get; }
}
