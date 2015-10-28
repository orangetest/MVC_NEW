using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{

    [MetadataType(typeof(Departments))]
    public class Departments
    {
        public int ID { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(50), Required]
        public string Address { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }

        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}