using SPMUsingEFC.DataAccess;
using SPMUsingEFC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC
{
    public class CourseService
    {
        public void Select()
        {
            using (var context = new StudentPerformanceManagementContext())
            {
                var courses = context.Courses.ToList();
                Console.WriteLine("                        Courses                     ");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("| CourseId | CourseCode | CourseTitle | Description |");
                Console.WriteLine("-----------------------------------------------------");
                foreach (var course in courses)
                {
                    Console.WriteLine($"| {course.courseID,(-10)} | {course.courseCode} | {course.courseTitle} | {course.description} |");
                }
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        public void Add()
        {
            var context = new StudentPerformanceManagementContext();

            Console.WriteLine("Enter Course Code = ");
            int courCode1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Course Title = ");
            var courseTitle1=Console.ReadLine();
            Console.WriteLine("Enter Course Description = ");
            var description1=Console.ReadLine();

            var course = new Course
            {
                courseCode = courCode1,
                courseTitle = courseTitle1,
                description = description1

            };
            context.Courses.Add(course);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record Inserted..!");
            context.Dispose();
        }
        public void Delete()
        {
            Console.WriteLine("Enter course Id to be deleted ");
            int courseId=int.Parse(Console.ReadLine());

            using var context = new StudentPerformanceManagementContext();
           
            var course = context.Courses.FirstOrDefault(x => x.courseID == courseId);
            if (course == null)
            {
                Console.WriteLine($"Course with Id = {courseId} not Found");
                return;
            }

            context.Courses.Remove(course);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record deleted..!");
        }
        public void Update()
        {
            Console.WriteLine("Enter id to be updated ");
            int courseId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Code = ");
            int courCode1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course Title = ");
            var courseTitle1 = Console.ReadLine();

            Console.WriteLine("Enter Course Description = ");
            var description1 = Console.ReadLine();

            using var context = new StudentPerformanceManagementContext();

            var course = context.Courses.FirstOrDefault(x => x.courseID == courseId);
            if (course == null)
            {
                Console.WriteLine($"Course with Id = {courseId} not Found");
                return;
            }

            course.courseCode = courCode1;
            course.courseTitle = courseTitle1;
            course.description = description1;

            context.Courses.Update(course);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record updated..!");
        }
    }
}




