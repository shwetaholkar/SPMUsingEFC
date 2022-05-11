using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC.DataAccess.Models
{
    [Table("Marks", Schema = "marks")]
    //[marks].[Marks]
    public class Mark
    {
        [Key]
        public int MarksID { get; set; }
        public int marks { get; set; }
        public int studentID { get; set; }
        [ForeignKey("studentID")]
        public Student student { get; set; }
        public int subjectID { get; set; }
        [ForeignKey("subjectID")]
        public Subject subject { get; set; }

    }
}
