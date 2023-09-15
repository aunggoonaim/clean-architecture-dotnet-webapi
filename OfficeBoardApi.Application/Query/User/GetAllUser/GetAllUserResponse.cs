namespace OfficeBoardApi.Application.Query.User.GetAllUser;

public sealed record GetAllUserResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
}