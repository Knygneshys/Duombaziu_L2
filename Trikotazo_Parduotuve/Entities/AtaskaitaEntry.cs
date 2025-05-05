using Microsoft.EntityFrameworkCore;

namespace Trikotazo_Parduotuve.Entities
{
    [Keyless]
    public class AtaskaitaEntry
    {
        public string Pavadinimas { get; set; }
        public float Kaina { get; set; }
        public string Medziaga { get; set; }
        public string Dydis { get; set; }
        public string Spalva { get; set; }
        public int Kiekis { get; set; }
        public string Tiekejas { get; set; }
    }
}
