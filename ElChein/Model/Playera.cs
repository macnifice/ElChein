using System.ComponentModel.DataAnnotations;

namespace ElChein.Model
{
    public class Playera
    {
        [Key]    
        int IdShirt { get; set; }
        string Size { get; set; }

        string Color { get; set; }

        string Material { get; set; }

        double Price { get; set; }

    }
}
