using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Kategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string pavadinimas { get; set; }
        public string? aprasymas { get; set; }
    }
}
