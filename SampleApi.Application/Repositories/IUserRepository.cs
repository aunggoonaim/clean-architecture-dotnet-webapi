using SampleApi.Domain.Entities;

namespace SampleApi.Application.Repositories;

public interface IUserRepository : IBaseRepository<UserModel>
{
    Task<UserModel> GetByEmail(string email, CancellationToken cancellationToken);
}