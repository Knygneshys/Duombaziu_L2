using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Trikotazas
    {
        [Key]
        public int Id { get; set; }
        public string  Pavadinimas { get; set; }
        public float Kaina { get; set; }
        public string Medziaga { get; set; }
        public string Dydis { get; set; }
        public string Spalva { get; set; }
        public int Kiekis { get; set; }
        public DateTime Paskutinis_atnaujinimas { get; set; }
        public string Fk_SUBKATEGORIJA_pav { get; set; }
        public int Fk_SUBKATEGORIJA_lytis { get; set; }
        public int Fk_TIEKEJAS { get; set; }

    }
}
