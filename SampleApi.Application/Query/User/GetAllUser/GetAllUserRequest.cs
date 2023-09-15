using MediatR;

namespace SampleApi.Application.Query.User.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;