using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSoftware
{
    internal class Input
    {
        public int GetId()
        {
            int id;
            bool validation;
            do
            {
                Console.Write("Please enter id: ");
                id = int.Parse(Console.ReadLine());
                validation = Validation.IsIdValid(id);
            } while (validation == false);           
            return id;
        }
        public string GetName()
        {
            string name;
            bool validation;
            do
            {
                Console.Write("Please enter name: ");
                name = Console.ReadLine();
                validation = Validation.IsNameValid(name);               
            } while (validation == false);
            return name;
        }

        public DateTime GetDateOfBirth()
        {
            DateTime dateOfbirth;
            bool validation;
            do
            {
                Console.Write("Please enter date of birth (MM/dd/yyyy): ");
                dateOfbirth = DateTime.Parse(Console.ReadLine());
                validation = Validation.IsDateOfBirthValid(dateOfbirth);
            } while (validation == false);
            return dateOfbirth;
        }
        public string GetAddress()
        {
            string address;
            bool validation;
            do
            {
                Console.Write("Please enter address: ");
                address = Console.ReadLine();
                validation = Validation.IsAddressValid(address);
            } while (validation == false);
            return address;
        }

        public float GetHeight()
        {
            float height;
            bool validation;
            do
            {
                Console.Write("Please enter height: ");
                height = float.Parse(Console.ReadLine());
                validation = Validation.IsHeightValid(height);
            } while (validation == false);
            return height;
        }
        public float GetWeight()
        {
            float weight;
            bool validation;
            do
            {
                Console.Write("Please enter weight: ");
                weight = float.Parse(Console.ReadLine());
                validation = Validation.IsWeightValid(weight);
            } while (validation == false);
            return weight;
        } 
        public string GetIdStudent()
        {
            string idStudent;
            bool validation;
            do
            {
                Console.Write("Please enter id student: ");
                idStudent = Console.ReadLine();
                validation = Validation.IsIdStudentValid(idStudent);
            } while (validation == false);
            return idStudent;
        }
        public string GetUniversity()
        {
            string university;
            bool validation;
            do
            {
                Console.Write("Please enter the university: ");
                university = Console.ReadLine();
                validation = Validation.IsUniversityValid(university);
            } while (validation == false);
            return university;
        }
        public int GetYearStart()
        {
            int yearStart;
            bool validation;
            do
            {
                Console.Write("Please enter the year you started studying: ");
                yearStart = int.Parse(Console.ReadLine());
                validation = Validation.IsYearStartValid(yearStart);
            } while (validation == false);
            return yearStart;
        }
        public float GetGpa()
        {
            float gpa;
            bool validation;
            do
            {
                Console.Write("Please enter cumulative GPA: ");
                gpa = float.Parse(Console.ReadLine());
                validation = Validation.IsGpaValid(gpa);
            } while (validation == false);
            return gpa;
        }
    }
}
