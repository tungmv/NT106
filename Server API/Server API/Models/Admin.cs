using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server_API.Models
{
    public class Admin
    {
        [Required]
        public string ID { get; set; }  // required since this is PK
        public string Hashed { get; set; }
        public string Salt { get; set; }
    }
}
