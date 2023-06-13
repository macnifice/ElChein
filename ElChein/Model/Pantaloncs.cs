using System.ComponentModel.DataAnnotations;

namespace ElChein.Model
{
    public class Pantaloncs
    {
        [Key]
        int IdPants { get; set; }
        string Size { get; set; }

        string Color { get; set; }

        string Material { get; set; }

        double Price { get; set; }
    }
}
