using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class LichSuDatVeNam
    {
        [ForeignKey("khachang")]
        [MaxLength(50)]
        public string ID_KhachHang {  get; set; }
        [MaxLength(20)]
        public string ID_VeNam { get; set; }

        public User User { get; set; }
    }
}
