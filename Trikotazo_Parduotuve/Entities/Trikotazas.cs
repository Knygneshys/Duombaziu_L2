using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class Trikotazas
    {
        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public float Kaina { get; set; }
        public string Medziaga { get; set; }
        public string Dydis { get; set; }
        public string Spalva { get; set; }
        public int Kiekis { get; set; }
        public DateTime Paskutinis_atnaujinimas { get; set; }
        public string Fk_SUBKATEGORIJA_pav { get; set; }
        public int Fk_SUBKATEGORIJA_lytis { get; set; }
        public int Fk_TIEKEJAS { get; set; }

        public Trikotazas()
        {
            
        }

        public Trikotazas(Trikotazas trikotazas)
        {
            Id = trikotazas.Id;
            Pavadinimas = trikotazas.Pavadinimas;
            Kaina = trikotazas.Kaina;
            Medziaga = trikotazas.Medziaga;
            Dydis = trikotazas.Dydis;
            Spalva = trikotazas.Spalva;
            Kiekis = trikotazas.Kiekis;
            Paskutinis_atnaujinimas = trikotazas.Paskutinis_atnaujinimas;
            Fk_SUBKATEGORIJA_pav = trikotazas.Fk_SUBKATEGORIJA_pav;
            Fk_SUBKATEGORIJA_lytis = trikotazas.Fk_SUBKATEGORIJA_lytis;
            Fk_TIEKEJAS = trikotazas.Fk_TIEKEJAS;
        }
    }
}
