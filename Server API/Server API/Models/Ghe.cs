using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Ghe
    {
        [Key]
        [MaxLength(15)]
        public string ID_Ghe { get; set; }
        [MaxLength(4)]
        public string Loai {  get; set; }
        [ForeignKey("Toa")]
        [MaxLength(15)]
        public string ID_Toa { get; set; }
    }
}
