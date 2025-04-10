using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagementSoftware
{
    internal static class Validation
    {
        public const int IdMin = 1;
        public const int NameMaxLength = 99;
        public const int YearMin = 1900;
        public const int AddressMaxLength = 299;
        public const float HeightMin = 50.0f;
        public const float HeightMax = 300.0f;
        public const float WeightMin = 5.0f;
        public const float WeightMax = 1000.0f;
        public const int IdStudentLength = 10;
        public const int UniversityMaxLength = 199;
        public const int YearStartMin = 1900;
        public const float GpaMin = 0.0f;
        public const float GpaMax = 10.0f;

        public static bool IsIdValid(int id)
        {
            if (id < IdMin)
            {
                Console.WriteLine($"Id must be greater than or equal to {IdMin}");
                return false;
            }
            return true;
        }
        public static bool IsNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty or spaced");
                return false;
            }
            if (name.Length > NameMaxLength) 
            {
                Console.WriteLine($"Name cannot be more than {NameMaxLength} characters");
                return false;
            }
            return true;
        }

        public static bool IsDateOfBirthValid(DateTime dateOfBirth)
        {
            
            if (dateOfBirth.Year < YearMin)
            {
                Console.WriteLine($"Year of birth must be from {YearMin}");
                return false;
            }
            return true;
        }
        public static bool IsAddressValid(string address)
        {
            if (address.Length > AddressMaxLength)
            {
                Console.WriteLine($"Address cannot be more than {AddressMaxLength} characters");
                return false;
            }
            return true;
        }

        public static bool IsHeightValid(float height)
        {
            if (height < HeightMin || height > HeightMax)
            {
                Console.WriteLine($"Height must be between {HeightMin} and {HeightMax}");
                return false;
            }
            return true;
        }

        public static bool IsWeightValid(float weight)
        {
            if (weight < WeightMin || weight > WeightMax)
            {
                Console.WriteLine($"Weight must be between {WeightMin} and {WeightMax}");
                return false;
            }
            return true;
        }

        public static bool IsIdStudentValid(string idStudent)
        {
            if (string.IsNullOrWhiteSpace(idStudent))
            {
                Console.WriteLine("Id student cannot be empty or spaced");
                return false;
            }
            if (idStudent.Length != IdStudentLength)
            {
                Console.WriteLine($"Id student must be {IdStudentLength} characters long");
                return false;
            }
            return true;
        }

        public static bool IsUniversityValid(string university)
        {
            if (string.IsNullOrWhiteSpace(university))
            {
                Console.WriteLine("University cannot be empty or spaced");
                return false;
            }
            if (university.Length > UniversityMaxLength)
            {
                Console.WriteLine($"University cannot be more than {UniversityMaxLength} characters");
                return false;
            }
            return true;
        }

        public static bool IsYearStartValid(int yearStart)
        {
            
            if (yearStart.ToString().Length != YearStartMin.ToString().Length)
            {
                Console.WriteLine($"Year start must be {YearStartMin.ToString().Length} characters long");
                return false;
            }
            if (yearStart < YearStartMin)
            {
                Console.WriteLine($"Year start must be from {YearStartMin}");
                return false;
            }
            return true;
        }

        public static bool IsGpaValid(float gpa)
        {
            if (gpa < GpaMin || gpa > GpaMax)
            {
                Console.WriteLine($"GPA must be between {GpaMin} and {GpaMax}");
                return false;
            }
            return true;
        }
    }
}
