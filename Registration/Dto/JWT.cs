﻿using NuGet.Packaging.Signing;

namespace Registration.Dto
{
    public class JWT
    {
        public string? key { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public double DurationInDays { get; set; }

    }
}
