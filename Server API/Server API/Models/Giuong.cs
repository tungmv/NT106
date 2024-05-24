namespace Server_API.Models
{
    public class Giuong
    {
        public string ID_Giuong { get; set; }
        public string ID_Phong { get; set; }

        public Phong Phong { get; set; }

        public VeNam VeNam { get; set; }
    }
}
