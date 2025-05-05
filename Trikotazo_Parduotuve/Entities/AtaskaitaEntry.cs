using Microsoft.EntityFrameworkCore;

namespace Trikotazo_Parduotuve.Entities
{
    [Keyless]
    public class AtaskaitaEntry
    {
        public string Kategorija { get; set; }
        public Lytis Lytis { get; set; }

        public float Kaina { get; set; }
        public string Tiekejas { get; set; }
    }
}
