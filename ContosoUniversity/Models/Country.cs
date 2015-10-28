using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Models;

namespace ContosoUniversity.Models
{
    [MetadataType(typeof(Country))]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        [StringLength(50)]
        [RegularExpression("^[a-zA-Zа-яА-Я]+$", ErrorMessage = "Must be a valid country name")]
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}