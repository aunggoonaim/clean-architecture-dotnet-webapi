using MediatR;

namespace OfficeBoardApi.Application.Query.User.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;