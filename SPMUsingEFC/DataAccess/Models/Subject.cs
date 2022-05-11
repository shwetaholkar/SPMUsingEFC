using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC.DataAccess.Models
{
    [Table("Subjects", Schema = "course")]
    //[course].[Subjects]
    public class Subject
    {
        [Key]
        public int subjectID { get; set; }
        public int subjectCode { get; set; }
        public string subjectTitle { get; set; }
        public string description { get; set; }
        public int courseID { get; set; }
        [ForeignKey("courseID")]
        public Course course { get; set; }
       
    }
}
