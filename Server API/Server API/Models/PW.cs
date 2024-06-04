using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Server_API.Models
{
    public class PW
    {
        [ForeignKey("khachhang")]
        public string ID_KhachHang { get; set; }
        public string Hashed {  get; set; }
        public string salt { get; set; }    // salt here is gonna be PK because why not

        [JsonIgnore]
        public User User { get; set; }
    }
}
