using System;
using System.Collections.Generic;

namespace ElChein.Model;

public partial class Pant
{
    public int IdPants { get; set; }

    public string Color { get; set; } = null!;

    public string? Material { get; set; }

    public decimal Price { get; set; }

    public string? Brand { get; set; }

    public string? Genere { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public int? S { get; set; }

    public int? M { get; set; }

    public int? L { get; set; }

    public int? Xl { get; set; }

    public int? Xxl { get; set; }

    public string? Image { get; set; }
}
