using System.Net;

namespace DotMK.Framework.Core.Exceptions;
public class ForbiddenException : CustomException
{
    public ForbiddenException() : base("You do not have permissions to access this resource.", HttpStatusCode.Forbidden)
    {
    }
}