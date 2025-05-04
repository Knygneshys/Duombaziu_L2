using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trikotazo_Parduotuve.Entities
{
    public class AtaskaitaTopic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Subkategorija { get; set; }
        public int Trikotazo_count { get; set; }
    }
}
