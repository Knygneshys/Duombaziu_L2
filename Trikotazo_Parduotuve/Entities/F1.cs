using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    [Keyless]
    public class F1
    {
        public string Pavadinimas { get; set; }
        public Lytis Lytis { get; set; }
        public string? Aprasymas { get; set; }
        public string Pav { get; set; }
        public string? Aprasas { get; set; }
    }
}
