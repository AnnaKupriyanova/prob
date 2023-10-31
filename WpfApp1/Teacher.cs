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
        private string last_name, first_name, middle_name, degree, position, exp;
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
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public Teacher() { }

        public Teacher(string last_name, string first_name, string middle_name, string degree, string position, string exp)
        {
            this.last_name = last_name;
            this.first_name = first_name;
            this.middle_name = middle_name;
            this.degree = degree;
            this.position = position;
            this.exp = exp;
        }

        public override string ToString()
        {
            return Last_name + " " + First_name + " " + Middle_name;
        }
    }
}
