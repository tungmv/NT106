namespace Server_API.Models
{
    public class Ghe
    {
        public string ID_Ghe { get; set; }
        public string ID_Toa { get; set; }

        public Toa Toa { get; set; }

        public VeNgoi VeNgoi { get; set; }
    }
}
