using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number"), Required]
        public int CourseID { get; set; }
        [StringLength(50), Required]
        public string Title { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number"), Required]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}