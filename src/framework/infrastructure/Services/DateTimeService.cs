﻿using DotMK.Framework.Core.Services;

namespace DotMK.Framework.Infrastructure.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime DateTimeUtcNow => DateTime.UtcNow;
    public DateOnly DateOnlyUtcNow => DateOnly.FromDateTime(DateTimeUtcNow);
}
