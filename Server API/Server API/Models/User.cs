using System.ComponentModel.DataAnnotations;

namespace Server_API.Models
{
    public class User
    {
        [Key]
        public string ID_KhachHang { get; set; }
        public string HoTen {  get; set; }
        [Required]
        public string Email { get; set; }
        public int NamSinh { get; set; }
        public DateTime NgayTao { get; set; }

        public  PW PW { get; set; }
    }
}
