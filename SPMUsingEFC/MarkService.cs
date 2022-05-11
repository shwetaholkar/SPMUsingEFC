using SPMUsingEFC.DataAccess;
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
    }
}
