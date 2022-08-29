using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCViewDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [ConcurrencyCheck]
        [MaxLength(24), MinLength(3)]
        public string Title { get; set; }
        //[Index(IsUnique = true)]
        public int Credits { get; set; }
        
        [Timestamp]
        public byte[] TStamp { get; set; }

        [InverseProperty("CurrCourse")]
        public virtual ICollection<Enrollment> CurrEnrollments { get; set; }
        [InverseProperty("PervCourse")]
        public virtual ICollection<Enrollment> PervEnrollments { get; set; }
    }
}
