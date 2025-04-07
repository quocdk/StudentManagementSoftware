using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSoftware
{
    internal class People
    {
        protected int id; 
        protected string name;
        protected DateOnly dateOfBirth;
        protected string address;
        protected float height; //chọn float vì là số thực và dùng ít bit hơn
        protected float weight; //chọn float vì là số thực và dùng ít bit hơn
        // Cần phải khai access modifier cho các trường là để đặt ra phạm vi có thể truy cập của các trường,
        // nhằm che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy

        // Có 5 loại phạm vi truy cập
        // public: Truy cập ở bất kì nơi nào
        // private: Truy cập giới hạn trong class định nghĩa 
        // protected: TTruy cập giới hạn trong class định nghĩa và các class con kế thừa class này
        // internal: Truy cập giới hạn trong phạm vi Assembly của dự án hiện tại
        // protected internal: Truy cập giới hạn trong phạm vi Assembly hiện tại và trong class định nghĩa hoặc các class con

        // Không khai báo access modifier cúng được vì khi không khai báo thì class sẽ mặc định là internal
        // còn thành phần bên trong class mặc định là private

        public People()
        {
            
        }

        public People(int id, string name, DateOnly dateOfBirth, string address, float height, float weight)
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
        public DateOnly DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }

        public void toString()
        {
            Console.WriteLine($"{id} | {name} | {dateOfBirth} | {address} | {height} | {weight}");
        }
    }
    
}
