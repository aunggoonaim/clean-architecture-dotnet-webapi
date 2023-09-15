using SampleApi.Domain.Common;

namespace SampleApi.Domain.Entities;

public sealed class UserModel : BaseEntity
{
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
}