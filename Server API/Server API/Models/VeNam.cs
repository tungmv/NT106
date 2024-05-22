using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class VeNam
    {
        [Key]
        [MaxLength(20)]
        public string ID_VeNam { get; set; }
        [ForeignKey("Tuyen")]   // Mot ve nam n - 1 Mot tuyen
        [MaxLength(15)]
        public string ID_Tuyen { get; set; }
        [ForeignKey("Giuong")]
        [MaxLength(15)]
        public string ID_Giuong { get; set; }
        public int DonGia { get; set; }
        public int KhaDung { get; set; }
        [MaxLength(100)]
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
    }
}
