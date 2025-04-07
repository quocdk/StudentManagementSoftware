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
            do
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Student Management");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Search student");
                Console.WriteLine("3. Edit student information");
                Console.WriteLine("4. Delete student");
                Console.WriteLine("5. View list student");
                Console.WriteLine("6.");
                Console.WriteLine("7.");
                Console.WriteLine("8.");
                Console.WriteLine("9.");
                Console.WriteLine("0.");
                Console.Write("Please enter your choice: ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        studentService.Create();
                        break;
                    case "2":
                        studentService.GetById();
                        break;
                    case "3":
                        studentService.Update();
                        break;
                    case "4":
                        studentService.Delete();
                        break;
                    case "5":
                        studentService.GetAll();
                        break;
                    case "6":
                        //studentService.ShowAvg();
                        break;
                    case "7":
                        //studentService.ShowStatus();
                        break;
                    case "8":
                        //studentService.ShowListStudentsByAvg();
                        break;
                    case "9":
                        //studentService.SaveToFile();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Option does not exist. Please select again.");
                        break;
                }
            } while (true);
        }
    }
}
