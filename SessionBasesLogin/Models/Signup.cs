using System;
using System.Collections.Generic;

namespace SessionBasesLogin.Models;

public partial class Signup
{
    public int? Id { get; set; }

    public string? Username { get; set; }

    public string Password { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }
}
