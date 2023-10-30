using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Teacher
    {
        public int id { get; set; }
        private string last_name, first_name, middle_name;
        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string Middle_name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }

        public Teacher() { }

        public Teacher(string last_name, string first_name, string middle_name)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.middle_name = middle_name;
        }

        public override string ToString()
        {
            return "Преподаватель:" + Last_name + " " + First_name + " " + Middle_name;
        }
    }
}
