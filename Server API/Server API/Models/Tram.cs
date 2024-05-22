using System.ComponentModel.DataAnnotations;

namespace Server_API.Models
{
    public class Tram
    {
        [Key]
        [MaxLength(15)]
        public string ID_Tram { get; set; }
        [MaxLength(30)]
        public string TenTram { get; set; }
        [MaxLength(30)]
        public string Thanhpho { get; set; }
        [MaxLength(15)]
        public string Tinh {  get; set; }

    }
}
