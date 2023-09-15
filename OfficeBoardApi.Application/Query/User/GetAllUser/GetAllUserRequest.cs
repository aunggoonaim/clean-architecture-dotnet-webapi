using MediatR;

namespace OfficeBoardApi.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;