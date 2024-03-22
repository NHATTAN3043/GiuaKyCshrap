using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Department
    {
        public int idD { get; set; }
        public string nameD { get; set; }

        public Department(int id, string name)
        {
            this.idD = id;
            this.nameD = name;
        }
        public static List<Department> departments()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "HR"));
            list.Add(new Department(2, "Marketing"));
            list.Add(new Department(3, "Security"));
            return list;
        }
    }
}
