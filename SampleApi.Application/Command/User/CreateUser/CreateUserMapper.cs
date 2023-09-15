using AutoMapper;
using SampleApi.Domain.Entities;

namespace SampleApi.Application.Command.User.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, UserModel>();
        CreateMap<UserModel, CreateUserResponse>();
    }
}