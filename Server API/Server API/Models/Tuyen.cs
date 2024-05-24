using System.ComponentModel.DataAnnotations;

namespace Server_API.Models
{
    public class Tuyen
    {
        [Key]
        [MaxLength(15)]
        public string ID_Tuyen { get; set; }
        [MaxLength(40)]
        public string TenTuyen { get; set; }

        public ICollection<DiemDi> DiemDi { get; set; }

        public ICollection<LichTrinh> LichTrinh { get; set; }
    }
}
