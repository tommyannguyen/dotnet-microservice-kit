﻿using System.Net;

namespace DotMK.Framework.Core.Exceptions;
public class NotFoundException : CustomException
{
    public NotFoundException(string message) : base(message, HttpStatusCode.NotFound)
    {
    }
}
