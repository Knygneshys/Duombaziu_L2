using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Tiekejas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Pavadinimas yra privalomas!")]
        public string Pavadinimas { get; set; }
        [Required(ErrorMessage = "Kontaktinis asmuo yra privalomas!")]
        public string Kontaktinis_asmuo { get; set; }
        public string? Tel_numeris { get; set; }
        [Required(ErrorMessage = "El. paštas yra privalomas!")]
        public string El_pastas { get; set; }
        [Required(ErrorMessage = "Adresas yra privalomas!")]
        public string Adresas { get; set; }

        public Tiekejas()
        {
            
        }
    }
}
