using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Server_API.Models
{
    public class LichSuDatVeNgoi
    {
        [ForeignKey("khachang")]
        [MaxLength(50)]
        public string ID_KhachHang { get; set; }
        [MaxLength(20)]
        public string ID_VeNgoi { get; set; }

        public User User { get; set; }
    }
}
