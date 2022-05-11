using Microsoft.EntityFrameworkCore;
using SPMUsingEFC.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC
{
    public class SubjectService
    {
        public void Select()
        {
            using (var context = new StudentPerformanceManagementContext())
            {
                var subjects = context.Subjects.Include("course").ToList();
                
                Console.WriteLine("                                Subjects                             ");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("| SubjectId | SubjectCode | SubjectTitle | Description | CourseTitle |");
                Console.WriteLine("----------------------------------------------------------------------");

                foreach (var subject in subjects)
                {
                    Console.WriteLine($"| {subject.subjectID} | {subject.subjectCode} | {subject.subjectTitle} | {subject.description} | {subject.course.courseTitle} |");
                }
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }
    }
}

