using System;
using System.Collections.Generic;

namespace Naranjillas1.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Year { get; set; }
}
