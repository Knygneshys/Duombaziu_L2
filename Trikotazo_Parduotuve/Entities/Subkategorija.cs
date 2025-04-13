using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Trikotazo_Parduotuve.Entities
{
    [PrimaryKey(nameof(pavadinimas), nameof(lytis))]
    public class Subkategorija
    {
        public string pavadinimas { get; set; }
        public Lytis lytis { get; set; }
        public string? aprasymas { get; set; }
        public Kategorija kategorija { get; set; }
    }
}
