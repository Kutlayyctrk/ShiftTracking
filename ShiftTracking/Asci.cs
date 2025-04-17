using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftTracking
{
    public class Asci
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Department { get; set; }
        public string Position { get; set; }
        public bool Durum { get; set; } = false; // true: aktif, false: pasif
        public override string ToString()
        {
            return $"{Name} {Surname} - {Department} ({Position}) [{(Durum ? "Aktif" : "Pasif")}]";
        }



        public Asci(string name, string surname, string department, string position)
        {
            Name = name;
            Surname = surname;
            Department = department;
            Position = position;
            Durum = false; // default olarak çalışıyor
        }

    }
}
