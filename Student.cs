using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class Student:People
    {
        private string idStudent;
        private string university;
        private int yearStart; 
        private float cumulativeGPA; 

        public Student()
        {
            
        }

        public Student(int id, string name, DateOnly dateOfBirth, string address, float height, float weight, string idStudent, string university, int yearStart, float cumulativeGPA) : base(id, name, dateOfBirth, address, height, weight)
        {
            this.idStudent = idStudent;
            this.university = university;
            this.yearStart = yearStart;
            this.cumulativeGPA = cumulativeGPA;
        }

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string University { get => university; set => university = value; }
        public int YearStart { get => yearStart; set => yearStart = value; }
        public float CumulativeGPA { get => cumulativeGPA; set => cumulativeGPA = value; }

        public void toString()
        {
            Console.WriteLine($"{id} | {name} | {dateOfBirth} | {address} | {height} | {weight} | {idStudent} | {university} | {yearStart} | {cumulativeGPA}");
        }
    }
}
