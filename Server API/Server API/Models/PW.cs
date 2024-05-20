using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class PW
    {
        [ForeignKey("khachhang")]
        public string ID_KhachHang { get; set; }
        public string Hashed {  get; set; }
        public string salt { get; set; }

        [Required]
        public User User { get; set; }
    }
}
