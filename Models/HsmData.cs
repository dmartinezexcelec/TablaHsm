using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HSM2.Models
{
    public class HsmData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string? SerialHsm { get; set; }
        public int? Reg { get; set; }
        public string? Sgc { get; set; }
        public string? Sgn { get; set; }
        public string? Bdt { get; set; }
        public int? Krn { get; set; }
        public DateTime? Act { get; set; }
        public string? Clm { get; set; }
        public string? Clu { get; set; }
        public string? Dkg { get; set; }
    }

}
