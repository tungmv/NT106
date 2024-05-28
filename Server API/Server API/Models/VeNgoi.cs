namespace Server_API.Models
{
    public class VeNgoi
    {
        public string ID_VeNgoi { get; set; }
        public string ID_LichTrinh { get; set; }
        public string ID_Ghe { get; set; }
        public string ID_Toa {  get; set; }
        public int DonGia { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string XuatPhat { get; set; }
        public string DiemDen { get; set; }
        // navigation props
        public Ghe Ghe { get; set; }

        public LichTrinh LichTrinh { get; set;}

        public DateTime ExpireDate { get; set; }
    }
}
