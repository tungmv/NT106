namespace Server_API.Models
{
    public class VeNgoi
    {
        public string ID_VeNgoi { get; set; }
        public string ID_Tuyen { get; set; }
        public string ID_Ghe { get; set; }
        public string ID_Toa {  get; set; }
        public int DonGia { get; set; }
        public int KhaDung { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public Ghe Ghe { get; set; }

        public Tuyen Tuyen { get; set;}
    }
}
