using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC.DataAccess.Models
{
    //[student].[Student]
    [Table("Student", Schema = "student")]
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public int studentRollno { get; set; }
        public string studentName { get; set; }
        public string studentEmail { get; set; }
        public string studentAddress { get; set; }
        public int courseID { get; set; }
        [ForeignKey ("courseID")] //course table column name
        public Course course { get; set; }
    }
}

