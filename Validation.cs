using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class Validation
    {
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

        public void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {

            }
            if (name.Length > NameMaxLength) 
            {
                throw new ArgumentException();
            }
        }
    }
}
