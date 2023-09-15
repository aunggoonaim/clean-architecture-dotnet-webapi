using AutoMapper;
using SampleApi.Domain.Entities;

namespace SampleApi.Application.Query.User.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<UserModel, GetAllUserResponse>();
    }
}