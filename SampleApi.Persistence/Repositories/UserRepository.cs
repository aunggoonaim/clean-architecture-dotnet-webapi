using SampleApi.Application.Repositories;
using SampleApi.Domain.Entities;
using SampleApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace SampleApi.Persistence.Repositories;

public class UserRepository : BaseRepository<UserModel>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }
    
    public Task<UserModel> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}