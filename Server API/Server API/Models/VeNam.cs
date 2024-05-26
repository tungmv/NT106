namespace Server_API.Models
{
    public class VeNam
    { 
        public string ID_VeNam { get; set; }
        public string ID_LichTrinh { get; set; }
        public string ID_Giuong { get; set; }
        public string ID_Phong { get; set; }
        public int DonGia { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public Giuong Giuong { get; set; }
        public LichTrinh LichTrinh { get; set; }

        public DateTime ExpireDate { get; set; }
    }
}
