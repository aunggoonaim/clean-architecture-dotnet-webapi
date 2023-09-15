using AutoMapper;
using OfficeBoardApi.Domain.Entities;

namespace OfficeBoardApi.Application.Query.User.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<UserModel, GetAllUserResponse>();
    }
}