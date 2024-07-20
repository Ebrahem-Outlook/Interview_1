using Interview.Domain.Core.BaseType;
using Microsoft.EntityFrameworkCore;

namespace Interview.Application.Core.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
