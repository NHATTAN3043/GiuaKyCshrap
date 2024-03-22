using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Employee
    {
        public int idE {  get; set; }
        public string nameE {  get; set; }
        public DateTime birthDay {  get; set; }
        public int idP { get; set; }
        public int idD { get; set; }

        public static List<Employee> employees()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "Nguyen Nhat Tan", new DateTime(2003, 04, 30), 1, 2));
            list.Add(new Employee(2, "Nguyen Nhat A", new DateTime(2003, 04, 30), 2, 2));
            list.Add(new Employee(3, "Nguyen Nhat B", new DateTime(2005, 08, 30), 2, 1));
            list.Add(new Employee(4, "Nguyen Nhat C", new DateTime(2003, 04, 30), 2, 1));
            list.Add(new Employee(5, "Nguyen Nhat D", new DateTime(2003, 04, 30), 3, 3));
            list.Add(new Employee(6, "Nguyen Nhat E", new DateTime(2003, 04, 30), 3, 2));
            list.Add(new Employee(7, "Nguyen Nhat F", new DateTime(2003, 04, 30), 4, 1));
            list.Add(new Employee(8, "Nguyen Nhat G", new DateTime(2003, 04, 30), 4, 3));
            return list;

        }
        public Employee(int idE, string nameE, DateTime birthDay, int idP, int idD)
        {
            this.idE = idE;
            this.nameE = nameE;
            this.birthDay = birthDay;
            this.idP = idP;
            this.idD = idD;
        }
        public int getAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDay.Year;
            if (birthDay.Day > today.Day) {
                age++;
            }else
                age--;
            return age;
        }
    }
}
