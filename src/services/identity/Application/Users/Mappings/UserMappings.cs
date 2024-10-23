using DotMK.Identity.Application.Users.Dtos;
using DotMK.Identity.Domain.Users;
using Mapster;

namespace DotMK.Identity.Application.Users.Mappings;
public sealed class UserMappings : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AppUser, UserDto>();
    }
}
