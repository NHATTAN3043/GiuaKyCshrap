using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Position
    {
        public int idP {  get; set; }
        public string nameP { get; set; }

        public Position(int idP, string nameP)
        {
            this.idP = idP;
            this.nameP = nameP;
        }
        public static List<Position> positions()
        {
            List<Position> list = new List<Position>();
            list.Add(new Position(1, "Project Manager"));
            list.Add(new Position(2, "Developper"));
            list.Add(new Position(3, "Tester"));
            list.Add(new Position(4, "Designer"));
            return list;
        }
    }
}
