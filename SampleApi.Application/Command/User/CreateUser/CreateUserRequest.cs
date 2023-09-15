using MediatR;

namespace SampleApi.Application.Command.User.CreateUser;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;