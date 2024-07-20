namespace Interview.Application.Core.Data;

public interface IUnitOfWork
{


    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
