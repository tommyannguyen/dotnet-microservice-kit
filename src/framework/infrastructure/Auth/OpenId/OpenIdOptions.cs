using DotMK.Framework.Infrastructure.Options;
using System.ComponentModel.DataAnnotations;

namespace DotMK.Framework.Infrastructure.Auth.OpenId;
public class OpenIdOptions : IOptionsRoot
{
    [Required(AllowEmptyStrings = false)]
    public string? Authority { get; set; } = string.Empty;
    [Required(AllowEmptyStrings = false)]
    public string? Audience { get; set; } = string.Empty;
}
