using AutoMapper;
using OfficeBoardApi.Domain.Entities;

namespace OfficeBoardApi.Application.Command.User.CreateUser;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, UserModel>();
        CreateMap<UserModel, CreateUserResponse>();
    }
}