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
        private ushort year; //chọn ushort vì là số nguyên dương và từ 0 đến 65,535
        private float cumulativeGPA; //chọn float vì là số thực và dùng ít bit hơn

        public Student()
        {
            
        }

        public Student(ushort id, string name, DateTime dateOfBirth, string address, float height, float weight, string idStudent, string university, ushort year, float cumulativeGPA) : base(id, name, dateOfBirth, address, height, weight)
        {
            this.idStudent = idStudent;
            this.university = university;
            this.year = year;
            this.cumulativeGPA = cumulativeGPA;
        }

        public void toString()
        {
            Console.WriteLine($"{id} {name} {dateOfBirth} {address} {height} {weight} {idStudent} {university} {year} {cumulativeGPA}");
        }
    }
}
