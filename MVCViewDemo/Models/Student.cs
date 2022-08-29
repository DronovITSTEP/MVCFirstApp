using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCViewDemo.Models
{
    [Table("StudentInfo", Schema = "Admin")]
    public class Student
    {
        [Key]
        public int StdntId { get; set; }
        [StringLength(60)]
        public string LastName { get; set; }
        [Required]
        [Column("First")]
        public string FirstName { get; set; }
        [NotMapped]
        public DateTime LastDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        public virtual Course CurrCourse { get; set; }
        public virtual Course PrevCourse { get; set; }

    }
}
