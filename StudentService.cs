using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class StudentService
    {
        private List<Student> listStudent;
        private Student student; 
        private int id = 4;
        private Input input = new Input();
        private FileStream fileStream;
        private BinaryFormatter binaryFormatter;
        private string path = @"D:\Hoc tap\Code\StudentManagementSoftware\Data.bin";
        public StudentService()
        {
            listStudent = new List<Student>()
            {
                new Student(1,"Quoc",DateTime.Parse("1/1/2001"),"TB",170,70,"PH00000001","FPT",2021,9),
                new Student(2,"Dung",DateTime.Parse("2/2/2002"),"HN",155,55,"PH00000002","FPT",2022,6),
                new Student(3,"Linh",DateTime.Parse("3/3/2003"),"QN",180,80,"PH00000003","FPT",2023,3),
            };
        }
        public void CreateStudent()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Add new student");
            student = new Student();
            student.Id = id;           
            student.Name = input.GetName();
            student.DateOfBirth = input.GetDateOfBirth();
            student.Address = input.GetAddress();
            student.Height = input.GetHeight();           
            student.Weight = input.GetWeight();
            student.IdStudent = input.GetIdStudent();
            student.University = input.GetUniversity();
            student.YearStart = input.GetYearStart();
            student.CumulativeGPA = input.GetGpa();
            student.UpdateAcademicPerformance();
            listStudent.Add(student);
            Console.WriteLine("Add new student successfully");
            student.toString();
            id++;
        }

        public void GetAllStudent()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("View list student");
            if (listStudent.Any())
            {
                foreach (Student student in listStudent)
                {
                    student.toString();
                }
            }
            else
            {
                Console.WriteLine($"There are no students");
            }
        }
        public Student GetStudentById()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Search student");        
            int id = input.GetId();
            student = listStudent.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student does not exist");
                return new Student();
            }
            else
            {
                student.toString();
                return student;
            }
        }
        public void UpdateStudent()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Edit student information");          
            student = GetStudentById();
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
                        student.Name = input.GetName();
                        break;
                    case "2":
                        student.DateOfBirth = input.GetDateOfBirth();
                        break;
                    case "3":
                        student.Address = input.GetAddress();
                        break;
                    case "4":
                        student.Height = input.GetHeight();
                        break;
                    case "5":
                        student.Weight = input.GetWeight();
                        break;
                    case "6":
                        student.University = input.GetUniversity();
                        break;
                    case "7":
                        student.YearStart = input.GetYearStart();
                        break;
                    case "8":
                        student.CumulativeGPA = input.GetGpa();
                        student.UpdateAcademicPerformance();
                        break;
                    default:
                        Console.WriteLine("Option does not exist. Please select again.");
                        break;
                }
                Console.WriteLine("Edit students successfully");
                student.toString();
            }          
        }
        public void DeleteStudent()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Delete student");
            int id = input.GetId();
            student = listStudent.FirstOrDefault(x => x.Id == id);
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

        public void GetPercentPerformance()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Shows academic performance percentage");          
            if (listStudent.Any()) 
            {
                var listPerformance = listStudent
                .GroupBy(s => s.AcademicPerformance)
                .Select(g => new
                {
                    Name = g.Key,
                    Percent = (float)g.Count() / listStudent.Count * 100
                })
                .OrderByDescending(p => p.Percent)
                .ToList();
                foreach (var performance in listPerformance)
                {
                    Console.WriteLine($"{performance.Name}: {performance.Percent}%");
                }
            }
            else
            {
                Console.WriteLine($"No students so no academic performance percentage list");
            }

        }
        public void GetPercentGPA()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Shows GPA percentage");          
            if (listStudent.Any())
            {
                Dictionary<float, int> gpa = new Dictionary<float, int>();
                foreach (var student in listStudent)
                {
                    if (gpa.ContainsKey(student.CumulativeGPA))
                    {
                        gpa[student.CumulativeGPA]++;
                    }
                    else
                    {
                        gpa[student.CumulativeGPA] = 1;
                    }
                }
                foreach (var i in gpa)
                {
                    float percent = (float)i.Value / listStudent.Count * 100;
                    Console.WriteLine($"{i.Key}: {percent}%");
                }
            }
            else
            {
                Console.WriteLine($"There are no students");
            }
            
        }
        public void ShowAllStudentByPerformance()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Print list students by academic performance");
            Console.WriteLine("Academic performance includes:");
            Console.WriteLine("1. Poor");
            Console.WriteLine("2. Weak");
            Console.WriteLine("3. Average");
            Console.WriteLine("4. Good");
            Console.WriteLine("5. Very Good");
            Console.WriteLine("6. Excellent");
            Console.Write("Please enter performance: ");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.Poor);
                    break;
                case "2":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.Weak);
                    break;
                case "3":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.Average);
                    break;
                case "4":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.Good);
                    break;
                case "5":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.VeryGood);
                    break;
                case "6":
                    GetAllStudentByPerformance(AcademicPerformanceEnum.Excellent);
                    break;              
                default:
                    Console.WriteLine("Option does not exist. Please select again.");
                    break;
            }
            
        }
        public void GetAllStudentByPerformance(AcademicPerformanceEnum performance)
        {
            if (listStudent.Any())
            {
                var listStudentPerformance = listStudent.Where(s => s.AcademicPerformance == performance).ToList();
                if (listStudentPerformance.Any())
                {
                    Console.WriteLine($"List students with performance {performance}:");
                    foreach (var student in listStudentPerformance)
                    {
                        student.toString();
                    }
                }
                else
                {
                    Console.WriteLine($"No students exist with {performance} academic performance");
                }
            }
            else
            {
                Console.WriteLine($"There are no students");
            }
        }

        public void SaveToFile()
        {
            fileStream = new FileStream(path,FileMode.Create);
            binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, listStudent);
            fileStream.Close();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("File saved successfully");
            
        }
        public void ReadFromFile()
        {
            fileStream = new FileStream(path,FileMode.Open);
            binaryFormatter = new BinaryFormatter();
            var data = binaryFormatter.Deserialize(fileStream);
            listStudent = new List<Student>();
            listStudent = (List<Student>)data;
            fileStream.Close();
            Console.WriteLine("Read file successfully");
        }
    }
}
