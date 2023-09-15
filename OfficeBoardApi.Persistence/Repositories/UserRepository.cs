using OfficeBoardApi.Application.Repositories;
using OfficeBoardApi.Domain.Entities;
using OfficeBoardApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace OfficeBoardApi.Persistence.Repositories;

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