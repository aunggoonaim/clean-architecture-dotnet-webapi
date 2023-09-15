using AutoMapper;
using OfficeBoardApi.Domain.Entities;

namespace OfficeBoardApi.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}