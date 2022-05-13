using SPMUsingEFC.DataAccess;
using SPMUsingEFC.DataAccess.Models;
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
        public void Add()
        {

            Console.WriteLine("Enter Student Rollno = ");
            int rollno1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name = ");
            var studentName1 = Console.ReadLine();

            Console.WriteLine("Enter Student Email = ");
            var email1 = Console.ReadLine();

            Console.WriteLine("Enter Student Address = ");
            var addr1 = Console.ReadLine();

            Console.WriteLine("Enter Course ID = ");
            int courseId1 = int.Parse(Console.ReadLine());

            var context = new StudentPerformanceManagementContext();

            var student = new Student
            {
                studentRollno = rollno1,
                studentName = studentName1,
                studentEmail= email1,
                studentAddress= addr1,
                courseID=courseId1

            };
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record Inserted..!");
            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter Student ID = ");
            int studId1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Rollno = ");
            int rollno1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name = ");
            var studentName1 = Console.ReadLine();

            Console.WriteLine("Enter Student Email = ");
            var email1 = Console.ReadLine();

            Console.WriteLine("Enter Student Address = ");
            var addr1 = Console.ReadLine();

            using var context = new StudentPerformanceManagementContext();

            var student = context.Students.FirstOrDefault(x => x.studentID == studId1);
            if (student == null)
            {
                Console.WriteLine($"Student with Id = {studId1} not Found");
                return;
            }

            student.studentRollno = rollno1;
            student.studentName = studentName1;
            student.studentEmail = email1;
            student.studentAddress = addr1;

            context.Students.Update(student);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record updated..!");
        }
        public void Delete()
        {
            Console.WriteLine("Enter student Id to be deleted ");
            int studentId = int.Parse(Console.ReadLine());

            using var context = new StudentPerformanceManagementContext();

            var student = context.Students.FirstOrDefault(x => x.studentID == studentId);
            if (student == null)
            {
                Console.WriteLine($"Student with Id = {studentId} not Found");
                return;
            }

            context.Students.Remove(student);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record deleted..!");
        }

    }
}



