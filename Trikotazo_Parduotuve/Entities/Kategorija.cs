using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Kategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Kategorijos pavadinimas yra būtinas!")]
        public string Pav { get; set; }
        public string? Aprasas { get; set; }
        public Kategorija()
        {

        }

        public Kategorija(Kategorija kategorija)
        {
            Pav = kategorija.Pav;
            Aprasas = kategorija.Aprasas;
        }

        public void Update(Kategorija kategorija)
        {
            Aprasas = kategorija.Aprasas;
        }

    }
}
