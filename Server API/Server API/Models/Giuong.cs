using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Giuong
    {
        [Key]
        [MaxLength(15)]
        public string ID_Giuong { get; set; }
        [ForeignKey("Phong")]
        [MaxLength(15)]
        public string ID_Phong { get; set; }
    }
}
