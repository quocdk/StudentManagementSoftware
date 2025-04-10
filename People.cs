using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    [Serializable]
    internal class People
    {
        protected int id; 
        protected string name;
        protected DateTime dateOfBirth;
        protected string address;
        protected float height; 
        protected float weight; 

        public People()
        {
            
        }

        public People(int id, string name, DateTime dateOfBirth, string address, float height, float weight)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.height = height;
            this.weight = weight;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }

        public void toString()
        {
            Console.WriteLine($"{id} | {name} | {dateOfBirth} | {address} | {height} | {weight}");
        }
    }
    
}
