using SPMUsingEFC.DataAccess;
using SPMUsingEFC.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC
{
    public class MarkService
    {
        public void Select()
        {
            using (var context = new StudentPerformanceManagementContext())
            {
                var marks = context.Marks.ToList();
                Console.WriteLine("-----------------Marks--------------");
                foreach (var mark in marks)
                {
                    Console.WriteLine($"{mark.MarksID}, {mark.marks}, {mark.studentID}, {mark.subjectID}");
                }
                Console.WriteLine("-------------------------------------");
            }
        }
        public void Add()
        {

            Console.WriteLine("Enter Marks = ");
            int marks1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student ID = ");
            int studId1= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject ID = ");
            int subId1= int.Parse(Console.ReadLine());


            var context = new StudentPerformanceManagementContext();

            var mark = new Mark
            {
                marks = marks1,
                studentID = studId1,
                subjectID = subId1,

            };
            context.Marks.Add(mark);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record Inserted..!");
            context.Dispose();
        }
        public void Update()
        {
            Console.WriteLine("Enter Mark ID = ");
            int markId1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks = ");
            int marks1 = int.Parse(Console.ReadLine());

            using var context = new StudentPerformanceManagementContext();

            var mark = context.Marks.FirstOrDefault(x => x.MarksID == markId1);
            if (mark == null)
            {
                Console.WriteLine($"Mark with Id = {markId1} not Found");
                return;
            }

            mark.marks = marks1;

            context.Marks.Update(mark);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record updated..!");
        }
        public void Delete()
        {

            Console.WriteLine("Enter marks Id to be deleted ");
            int markId = int.Parse(Console.ReadLine());

            using var context = new StudentPerformanceManagementContext();

            var mark = context.Marks.FirstOrDefault(x => x.MarksID == markId);
            if (mark == null)
            {
                Console.WriteLine($"Mark with Id = {markId} not Found");
                return;
            }

            context.Marks.Remove(mark);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Record deleted..!");
        }
    }
}
