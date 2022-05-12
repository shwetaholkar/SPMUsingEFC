using Microsoft.EntityFrameworkCore;
using SPMUsingEFC.DataAccess;
using SPMUsingEFC.DataAccess.Models;
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
        public void Add()
        {

            Console.WriteLine("Enter Subject Code = ");
            int subCode1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject Title = ");
            var subTitle1 = Console.ReadLine();

            Console.WriteLine("Enter Subject Description = ");
            var desc1 = Console.ReadLine();

            Console.WriteLine("Enter Course ID = ");
            int courseId1 = int.Parse(Console.ReadLine());

            var context = new StudentPerformanceManagementContext();

            var subject = new Subject
            {
                subjectCode = subCode1,
                subjectTitle = subTitle1,
                description = desc1,
                courseID = courseId1

            };
            context.Subjects.Add(subject);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record Inserted..!");
            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter Subject ID = ");
            int subId1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject Code = ");
            int subCode1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject Title = ");
            var subTitle1 = Console.ReadLine();

            Console.WriteLine("Enter Subject Description = ");
            var desc1 = Console.ReadLine();

            using var context = new StudentPerformanceManagementContext();

            var subject = context.Subjects.FirstOrDefault(x => x.subjectID == subId1);
            if (subject == null)
            {
                Console.WriteLine($"Subject with Id = {subId1} not Found");
                return;
            }

            subject.subjectCode = subCode1;
            subject.subjectTitle = subTitle1;
            subject.description = desc1;
            
            context.Subjects.Update(subject);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record updated..!");
        }
        public void Delete()
        {

        }
    }
}

