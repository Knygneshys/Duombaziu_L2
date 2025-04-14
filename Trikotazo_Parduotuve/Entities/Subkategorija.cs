using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Trikotazo_Parduotuve.Entities
{
    [PrimaryKey(nameof(Pavadinimas), nameof(Lytis))]
    public class Subkategorija
    {
        [Required(ErrorMessage ="Pavadinimas yra privalomas!")]
        public string Pavadinimas { get; set; }
        [Required(ErrorMessage = "Lytis yra privaloma!")]
        public Lytis Lytis { get; set; }
        public string? Aprasymas { get; set; }
        public string Fk_KATEGORIJA { get; set; }

        public Subkategorija()
        {
            
        }

        public Subkategorija(Subkategorija subkategorija)
        {
            Pavadinimas = subkategorija.Pavadinimas;
            Lytis = subkategorija.Lytis;
            Aprasymas = subkategorija.Aprasymas;
            Fk_KATEGORIJA = subkategorija.Fk_KATEGORIJA;
        }

        public void Update(Subkategorija subkategorija)
        {
            Pavadinimas = subkategorija.Pavadinimas;
            Lytis = subkategorija.Lytis;
            Aprasymas = subkategorija.Aprasymas;
            Fk_KATEGORIJA = subkategorija.Fk_KATEGORIJA;
        }
    }
}
