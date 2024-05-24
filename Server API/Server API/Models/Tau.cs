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
        public string Lop { get; set; }

        public ICollection<Toa> Toa { get; set; }
        public Tuyen Tuyen { get; set; }

        public ICollection<LichTrinh> LichTrinh { get; set; }
    }
}
