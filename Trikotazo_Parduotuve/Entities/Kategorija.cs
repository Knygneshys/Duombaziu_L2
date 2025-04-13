using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Kategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Pavadinimas { get; set; }
        public string? Aprasymas { get; set; }
    }
}
