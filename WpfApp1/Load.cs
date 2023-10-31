using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Load
    {
        public int id {  get; set; }
        private string teacher, subject, group, type;
        public string Teacher { get {  return teacher; } set {  teacher = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string Group { get { return group; } set { group = value; } }
        public string Type { get { return type; } set { type = value; } }

        public Load() { }
        public Load(string teacher, string subject, string group, string type)
        {
            this.teacher = teacher;
            this.subject = subject;
            this.group = group;
            this.type = type;
        }
    }
}
