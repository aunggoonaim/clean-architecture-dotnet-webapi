using OfficeBoardApi.Domain.Entities;

namespace OfficeBoardApi.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}