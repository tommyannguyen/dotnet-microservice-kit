using DotMK.Framework.Core.Exceptions;
using System.Net;

namespace DotMK.Identity.Application.Users.Exceptions;
public class UserRegistrationException : CustomException
{
    public UserRegistrationException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base(message, statusCode)
    {
    }
}
