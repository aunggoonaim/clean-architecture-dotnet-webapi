using OfficeBoardApi.Domain.Entities;

namespace OfficeBoardApi.Application.Repositories;

public interface IUserRepository : IBaseRepository<UserModel>
{
    Task<UserModel> GetByEmail(string email, CancellationToken cancellationToken);
}