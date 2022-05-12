using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMUsingEFC
{
    public class Menu
    {


        public void Start()
        {
            CourseService courseService = new CourseService();
            StudentService studentService = new StudentService();
            SubjectService subjectService = new SubjectService();
            MarkService markService = new MarkService();

            int num = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine(" 1. Add Student ");
                Console.WriteLine(" 2. Add course ");
                Console.WriteLine(" 3. Add subject ");
                Console.WriteLine(" 4. Enter marks of student ");
                Console.WriteLine(" 5. Edit Student data");
                Console.WriteLine(" 6. Edit course ");
                Console.WriteLine(" 7. Edit subject ");
                Console.WriteLine(" 8. Delete Student ");
                Console.WriteLine(" 9. Delete Subject ");
                Console.WriteLine(" 10. Delete Course ");
                Console.WriteLine(" 11. Delete marks ");
                Console.WriteLine(" 12. List all students with details of course, subject, and total marks ");
                Console.WriteLine(" 13. Display subject wise marks for a student ");
                Console.WriteLine(" 14. List course wise average marks ");
                Console.WriteLine(" 15. List course wise max marks ");
                Console.WriteLine(" 16. List course wise topper ");

                Console.WriteLine(" Enter your choice : ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        studentService.Add();
                        break;

                    case 2:
                        courseService.Add();
                        break;

                    case 3:
                        subjectService.Add();
                        break;

                    case 4:
                        markService.Add();
                        break;

                    case 5:
                        studentService.Update();
                        break;

                    case 6:
                        courseService.Update();
                        break;

                    case 7:
                        subjectService.Update();
                        break;

                    case 8:
                        
                        break;

                    case 9:
                        
                        break;

                    case 10:
                       courseService.Delete();
                        break;

                    case 11:
                       
                        break;

                    case 12:
                        
                        break;

                    case 13:
                        
                        break;

                    case 14:
                        
                        break;

                    case 15:
                        
                        break;

                    case 16:
                        
                        break;

                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }

            } while (num > 0);

        }


    }
}
