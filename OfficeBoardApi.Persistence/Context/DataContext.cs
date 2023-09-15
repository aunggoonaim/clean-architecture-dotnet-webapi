using OfficeBoardApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace OfficeBoardApi.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}