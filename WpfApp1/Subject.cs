using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Subject
    {
        public int id { get; set; }
        private string name, hours;
        public string Name { get { return name; } set {  name = value; } }
        public string Hours { get { return hours; } set { hours = value; } }

        public Subject() { }
        public Subject(string name, string hours)
        {
            this.name = name;
            this.hours = hours;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
