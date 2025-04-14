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
        [Required(ErrorMessage = "Pavadinimas yra privaloma!")]
        public Lytis Lytis { get; set; }
        public string? Aprasymas { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
