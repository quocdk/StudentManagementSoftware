using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    [Serializable]
    internal class Student:People
    {
        private string idStudent;
        private string university;
        private int yearStart;
        private float cumulativeGPA;
        private AcademicPerformanceEnum academicPerformance;

        public Student()
        {
            
        }

        public Student(int id, string name, DateTime dateOfBirth, string address, float height, float weight, string idStudent, string university, int yearStart, float cumulativeGPA) : base(id, name, dateOfBirth, address, height, weight)
        {
            this.idStudent = idStudent;
            this.university = university;
            this.yearStart = yearStart;
            this.cumulativeGPA = cumulativeGPA;
            UpdateAcademicPerformance();
        }

        public string IdStudent { get => idStudent; set => idStudent = value; }
        public string University { get => university; set => university = value; }
        public int YearStart { get => yearStart; set => yearStart = value; }
        public float CumulativeGPA { get => cumulativeGPA; set => cumulativeGPA = value; }
        public AcademicPerformanceEnum AcademicPerformance { get => academicPerformance; set => academicPerformance = value; }

        public void UpdateAcademicPerformance()
        {
            if (CumulativeGPA < 3)
                AcademicPerformance = AcademicPerformanceEnum.Poor;
            else if (CumulativeGPA < 5)
                AcademicPerformance = AcademicPerformanceEnum.Weak;
            else if (CumulativeGPA < 6.5)
                AcademicPerformance = AcademicPerformanceEnum.Average;
            else if (CumulativeGPA < 7.5)
                AcademicPerformance = AcademicPerformanceEnum.Good;
            else if (CumulativeGPA < 9)
                AcademicPerformance = AcademicPerformanceEnum.VeryGood;
            else
                AcademicPerformance = AcademicPerformanceEnum.Excellent;
        }
        public void toString()
        {
            Console.WriteLine($"{id} | {name} | {dateOfBirth} | {address} | {height} | {weight} | {idStudent} | {university} | {yearStart} | {cumulativeGPA} | {AcademicPerformance}");
        }
    }
}
