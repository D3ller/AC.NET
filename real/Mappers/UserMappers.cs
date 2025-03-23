using real.Dtos.User;
using real.Models;

namespace real.Mappers;

public static class UserMappers
{
    public static UserDto ViewUserDto(this User userModel)
    {
        return new UserDto
        {
            Id = userModel.Id,
            Username = userModel.Username
        };
    }

    public static User ToCreateUserDto(this CreateUserDto createUserDto)
    {
        return new User
        {
            Username = createUserDto.Username,
            Email = createUserDto.Email,
            Password = createUserDto.Password
        };
    }
}