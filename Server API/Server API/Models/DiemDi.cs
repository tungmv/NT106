using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace Server_API.Models
{
    public class DiemDi
    {
        [ForeignKey("Tuyen")]
        [MaxLength(15)]
        public string ID_Tuyen { get; set; }

        [ForeignKey("Tram")]
        [MaxLength(15)]
        public string ID_Tram { get; set; }
        public float KhoangCach { get; set; }
    }
}
