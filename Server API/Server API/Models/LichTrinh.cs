using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        public string ID_Tau { get; set; }
        public TimeSpan Gio { get; set; }

        [AllowNull]
        public DayOfWeek? Thu { get; set; }  // Mot lich trinh khong co thu nghia la hang ngay vao {gio} se co tau, lich trich co thu nghia la {thu}, {gio} hang tuan

        public int Chieu { get; set; }      // 0 la di, 1 la ve
        // navigation props
        public Tau Tau { get; set; }
        public Tuyen Tuyen { get; set; }
    }
}
