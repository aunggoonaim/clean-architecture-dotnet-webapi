using SampleApi.Domain.Common;

namespace SampleApi.Domain.Entities;

public sealed class UserModel : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
}