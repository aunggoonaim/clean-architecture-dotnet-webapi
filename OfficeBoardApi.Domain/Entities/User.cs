using OfficeBoardApi.Domain.Common;

namespace OfficeBoardApi.Domain.Entities;

public sealed class User : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
}