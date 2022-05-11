using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC.DataAccess.Models
{
    //[course].[Course]
    [Table("Course", Schema = "course")]
    public class Course
    {
        [Key]
        public int courseID { get; set; }
        public int courseCode { get; set; }
        public string courseTitle { get; set; }
        public string description { get; set; }
    }
}
