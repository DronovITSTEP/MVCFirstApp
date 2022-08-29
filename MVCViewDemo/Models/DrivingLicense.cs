using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCViewDemo.Models
{
    public class DrivingLicense
    {
        [Key, Column(Order = 1)]
        public int LicenseNumber { get; set; }
        [Key, Column(Order = 1)]
        public string LicenseName { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DateTime2 { get; set; }
    }
}
