using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        [Key]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number"), Required]
        public int InstructorID { get; set; }
        [StringLength(50), Required]
        public string Title { get; set; }
        [Range(1, 150, ErrorMessage = "Please enter valid integer Number"), Required]
        public int Age { get; set; }

        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[NotMapped]
       // public virtual List<Country> Countries { get; set; }

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}