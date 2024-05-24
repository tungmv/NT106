using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Toa
    {
        [Key]
        [MaxLength(15)]
        public string ID_Toa { get; set; }
        [MaxLength(10)]
        public string Loai {  get; set; }
        [ForeignKey("Tau")]
        [MaxLength(15)]
        public string ID_Tau { get; set; }

        public Tau Tau { get; set; }

        public ICollection<Ghe> Ghe { get; set; }
        public ICollection<Phong> Phong { get; set; }
    }
}
