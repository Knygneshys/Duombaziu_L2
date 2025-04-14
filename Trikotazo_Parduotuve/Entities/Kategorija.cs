using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Kategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Kategorijos pavadinimas yra būtinas!")]
        public string Pavadinimas { get; set; }
        public string? Aprasymas { get; set; }

        public Kategorija(Kategorija kategorija)
        {
            Pavadinimas = kategorija.Pavadinimas;
            Aprasymas = kategorija.Aprasymas;
        }

        public Kategorija()
        {
            
        }
    }
}
