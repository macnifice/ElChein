using System;
using System.Collections.Generic;

namespace ElChein.Model;

public partial class Pant
{
    public int IdPants { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public string? Material { get; set; }

    public decimal? Price { get; set; }
}
