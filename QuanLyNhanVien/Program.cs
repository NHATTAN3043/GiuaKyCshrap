using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Employee> employees = Employee.employees();
            List<Position> positions = Position.positions();
            List<Department> departments = Department.departments();
            // Nhập thông tin tìm kiếm từ người dùng
            Console.Write("Nhập tên:");
            string keyword = Console.ReadLine();
            Console.Write("Tuổi từ:");
            int minAge = int.Parse(Console.ReadLine());
            Console.Write("Đến tuổi:");
            int maxAge = int.Parse(Console.ReadLine());
            Console.Write("Vị trí:");
            string position = Console.ReadLine();
            Console.Write("Phòng ban:");
            string department = Console.ReadLine();

            var resuilt = from ems in employees
                          join pos in positions on ems.idP equals pos.idP
                          join des in departments on ems.idD equals des.idD
                          where ((keyword.Equals(ems.nameE) || position.Equals(pos.nameP) || department.Equals(des.nameD)) && (ems.getAge() >= minAge && ems.getAge() <= maxAge))
                          select new
                          {
                              nameEmployee = ems.nameE,
                              namePosition = pos.nameP,
                              nameDepartment = des.nameD,
                              age = ems.getAge()
                          };
            foreach(var item in resuilt)
            {
                Console.WriteLine($"Tên nhân viên: {item.nameEmployee}, Tuổi: {item.age}, Vị trí: {item.namePosition}, Phòng ban: {item.nameDepartment}");
            }
        }
    }
}
