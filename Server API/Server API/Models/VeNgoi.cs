using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class VeNgoi
    {
        [Key]
        [MaxLength(20)]
        public string ID_VeNgoi { get; set; }
        [ForeignKey("Tuyen")]
        [MaxLength(15)]
        public string ID_Tuyen { get; set; }
        [ForeignKey("Ghe")]
        [MaxLength(15)]
        public string ID_Ghe { get; set; }
        public int DonGia { get; set; }
        public int KhaDung { get; set; }
        [MaxLength(100)]
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
    }
}
