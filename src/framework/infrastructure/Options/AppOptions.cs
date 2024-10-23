using System.ComponentModel.DataAnnotations;

namespace DotMK.Framework.Infrastructure.Options
{
    public class AppOptions : IOptionsRoot
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; } = "DotMK.WebAPI";
    }
}
