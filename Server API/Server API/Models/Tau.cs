using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Tau
    {
        [Key]
        [MaxLength(15)]
        public string ID_Tau { get; set; }
        public int TuoiTho {  get; set; }
    }
}
