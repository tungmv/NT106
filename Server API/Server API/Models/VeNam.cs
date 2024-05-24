namespace Server_API.Models
{
    public class VeNam
    { 
        public string ID_VeNam { get; set; }
        public string ID_Tuyen { get; set; }
        public string ID_Giuong { get; set; }
        public string ID_Phong { get; set; }
        public int DonGia { get; set; }
        public int KhaDung { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public Giuong Giuong { get; set; }
        public Tuyen Tuyen { get; set; }
    }
}
