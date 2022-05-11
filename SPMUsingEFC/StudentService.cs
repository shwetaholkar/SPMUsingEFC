using SPMUsingEFC.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC
{
    public class StudentService
    {
        public void Select()
        {
            using (var context = new StudentPerformanceManagementContext())
            {
                var students = context.Students.ToList();
                Console.WriteLine("-----------------Students--------------");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.studentID}, {student.studentRollno}, {student.studentName}, {student.studentEmail}, {student.studentAddress}, {student.courseID}");
                }
                Console.WriteLine("-------------------------------------");
            }
        }

    }
}
