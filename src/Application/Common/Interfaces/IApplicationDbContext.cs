using RestApiTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace RestApiTemplate.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<GeoPosition> TodoLists { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
