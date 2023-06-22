using System;
using System.Collections.Generic;

namespace ElChein.Model;

public partial class Shirt
{
    public int IdShirt { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public string? Material { get; set; }

    public decimal? Price { get; set; }
}
