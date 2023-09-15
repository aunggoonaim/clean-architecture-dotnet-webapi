using SampleApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SampleApi.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }
}