using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            studentService.ReadFromFile();
            do
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Student Management");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. View list student");
                Console.WriteLine("3. Search student");
                Console.WriteLine("4. Edit student information");
                Console.WriteLine("5. Delete student");
                Console.WriteLine("6. Shows academic performance percentage");
                Console.WriteLine("7. Shows GPA percentage");
                Console.WriteLine("8. Print list students by academic performance");
                Console.WriteLine("9. Save file and exit program");
                Console.Write("Please enter your choice: ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        studentService.CreateStudent();
                        break;
                    case "2":
                        studentService.GetAllStudent();
                        break;
                    case "3":
                        studentService.GetStudentById();
                        break;
                    case "4":
                        studentService.UpdateStudent();
                        break;
                    case "5":
                        studentService.DeleteStudent();
                        break;
                    case "6":
                        studentService.GetPercentPerformance();
                        break;
                    case "7":
                        studentService.GetPercentGPA();
                        break;
                    case "8":
                        studentService.ShowAllStudentByPerformance();
                        break;                    
                    case "9":
                        studentService.SaveToFile();
                        Console.WriteLine("Program exited");
                        return;
                    //case "0":
                    //    studentService.ReadFromFile();
                    //    break;
                    default:
                        Console.WriteLine("Option does not exist. Please select again.");
                        break;
                }
            } while (true);
        }
    }
}
