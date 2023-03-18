using RestApiTemplate.Application.Common.Interfaces;

namespace RestApiTemplate.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.UtcNow;
}
