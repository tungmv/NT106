using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class LichTrinh
    {
        [Key]
        [MaxLength(15)]
        public string ID_LichTrinh { get; set; }
        [ForeignKey("Tuyen")]
        [MaxLength(15)]
        public string ID_Tuyen { get; set; }
        [ForeignKey("Tau")]
        [MaxLength(15)]
        public string Id_Tau { get; set; }
        public DateTime KhoiHanh { get; set; }
    }
}
