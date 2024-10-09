using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_class_with_properties_and_methods
{
    internal class Student
    {
        public DateTime admissionDateTime;
        int id;
        string name;

        public Student()
        {
            admissionDateTime = DateTime.Now;
        }
    }
}
