using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class StudentService
    {
        private List<Student> listStudent = new List<Student>();
        private Student student = new Student();
        private string _input;
        public StudentService()
        {
            listStudent = new List<Student>()
            {
                new Student(1,"A",DateOnly.Parse("1/1/2001"),"A",1,1,"001","A",2021,1),
                new Student(2,"B",DateOnly.Parse("2/2/2002"),"B",2,2,"002","B",2022,2),
                new Student(3,"C",DateOnly.Parse("3/3/2003"),"C",3,3,"003","C",2023,3),
                
            };
        }
        public void Create()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Add new student");
            student = new Student();
            Console.Write("Please enter id: ");
            student.Id = int.Parse(Console.ReadLine());
            Console.Write("Please enter name: ");
            student.Name = Console.ReadLine();
            Console.Write("Please enter date of birth: ");
            student.DateOfBirth = DateOnly.Parse(Console.ReadLine());
            Console.Write("Please enter address: ");
            student.Address = Console.ReadLine();
            Console.Write("Please enter height: ");
            student.Height = float.Parse(Console.ReadLine());
            Console.Write("Please enter weight: ");
            student.Weight = float.Parse(Console.ReadLine());
            Console.Write("Please enter id student: ");
            student.IdStudent = Console.ReadLine();
            Console.Write("Please enter the university: ");
            student.University = Console.ReadLine();
            Console.Write("Please enter the year you started studying: ");
            student.YearStart = int.Parse(Console.ReadLine());
            Console.Write("Please enter cumulative GPA: ");
            student.CumulativeGPA = float.Parse(Console.ReadLine());
            listStudent.Add(student);
            Console.WriteLine("Add new student successfully");
            student.toString();
        }

        public void GetAll()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("View list student");
            foreach (Student student in listStudent)
            {
                student.toString();
            }
        }
        public void GetById()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Search student");
            Console.Write("Please enter id: ");
            _input = Console.ReadLine();
            student = listStudent.FirstOrDefault(x => x.Id == int.Parse(_input));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
            }
            else
            {
                student.toString();
            }
        }
        public void Update()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Edit student information");
            Console.Write("Please enter id: ");
            _input = Console.ReadLine();
            student = listStudent.FirstOrDefault(x => x.Id == int.Parse(_input));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
            }
            else
            {
                Console.WriteLine("What information do you want to edit?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Date of birth");
                Console.WriteLine("3. Address");
                Console.WriteLine("4. Height");
                Console.WriteLine("5. Weight");
                Console.WriteLine("6. University");
                Console.WriteLine("7. Year of commencement of study");
                Console.WriteLine("8. Cumulative GPA");
                Console.Write("Please enter your choice: ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.Write("Please enter name: ");
                        student.Name = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Please enter your date of birth: ");
                        student.DateOfBirth = DateOnly.Parse(Console.ReadLine());
                        break;
                    case "3":
                        Console.Write("Please enter address: ");
                        student.Address = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Please enter height: ");
                        student.Height = float.Parse(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("Please enter weight: ");
                        student.Weight = float.Parse(Console.ReadLine());
                        break;
                    case "6":
                        Console.Write("Please enter the university: ");
                        student.University = Console.ReadLine();
                        break;
                    case "7":
                        Console.Write("Please enter the year you started studying: ");
                        student.YearStart = int.Parse(Console.ReadLine());
                        break;
                    case "8":
                        Console.Write("Please enter cumulative GPA: ");
                        student.CumulativeGPA = float.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Option does not exist. Please select again.");
                        break;
                }
                Console.WriteLine("Edit students successfully");
                student.toString();
            }          
        }
        public void Delete()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Delete student");
            Console.Write("Please enter id: ");
            _input = Console.ReadLine();
            student = listStudent.FirstOrDefault(x => x.Id == int.Parse(_input));
            if (student == null)
            {
                Console.WriteLine("Student does not exist");               
            }
            else
            {
                listStudent.Remove(student);
                Console.WriteLine("Delete successful");
            }          
        }
    }
}
