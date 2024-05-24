using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Phong
    {
        [Key]
        [MaxLength(15)]
        public string ID_Phong { get; set; }
        [ForeignKey("Toa")]
        [MaxLength(15)]
        public string ID_Toa { get; set; }

        public Toa Toa { get; set; }

        public ICollection<Giuong> Giuong { get; set; }
    }
}
