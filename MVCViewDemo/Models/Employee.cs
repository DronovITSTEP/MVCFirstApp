using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCViewDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Range(22,60)]
        public int Age { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
