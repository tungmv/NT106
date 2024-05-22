using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Phong
    {
        [Key]
        [MaxLength(15)]
        public string ID_Phong { get; set; }
        [MaxLength(1)]
        public string Loai {  get; set; } // 4 || 6
        [ForeignKey("Toa")]
        [MaxLength(15)]
        public string ID_Toa { get; set; }
    }
}
