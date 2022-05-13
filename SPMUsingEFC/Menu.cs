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
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                   Course                ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Display all Course ");
                Console.WriteLine("2. Add Course ");
                Console.WriteLine("3. Update Course ");
                Console.WriteLine("4. Delete Course ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                   Student                ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("5. Display all Student ");
                Console.WriteLine("6. Add Student ");
                Console.WriteLine("7. Update Student ");
                Console.WriteLine("8. Delete Student ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                   Subject                ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("9. Display all Subject ");
                Console.WriteLine("10. Add Subject ");
                Console.WriteLine("11. Update Subject ");
                Console.WriteLine("12. Delete Subject ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                   Mark                  ");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("13. Display all Marks ");
                Console.WriteLine("14. Add Marks ");
                Console.WriteLine("15. Update Marks ");
                Console.WriteLine("16. Delete Marks ");

                Console.WriteLine();
                Console.WriteLine("Enter your choice : ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        courseService.Select();
                        break;

                    case 2:
                        courseService.Add();
                        break;

                    case 3:
                        courseService.Update();
                        break;

                    case 4:
                        courseService.Delete();
                        break;

                    case 5:
                        studentService.Select();
                        break;

                    case 6:
                        studentService.Add();
                        break;

                    case 7:
                        studentService.Update();
                        break;

                    case 8:
                        studentService.Delete();
                        break;

                    case 9:
                        subjectService.Select();
                        break;

                    case 10:
                        subjectService.Add();
                        break;

                    case 11:
                        subjectService.Update();
                        break;

                    case 12:
                        subjectService.Delete();
                        break;

                    case 13:
                        markService.Select();
                        break;

                    case 14:
                        markService.Add();
                        break;

                    case 15:
                        markService.Update();
                        break;

                    case 16:
                        markService.Delete();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }

            } while (num > 0);
        }
    }
}
