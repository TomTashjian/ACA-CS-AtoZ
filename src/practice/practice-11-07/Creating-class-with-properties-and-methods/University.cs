using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_class_with_properties_and_methods
{
    class University
    {
        public String Name { get; set; }
        public DateTime FoundedAt { get; set; }
        private Student[] Students { get; set; }

        private int lastIndex;

        public University(string name)
        {
            Students = new Student[1000];
            FoundedAt = DateTime.Now;
            Name = name;
            lastIndex = 0;
        }

        public void GetAdmitted(String studentName, int id)
        {
            if(lastIndex == (Students.Length - 1))
            {
                Array.Resize<Student>(ref Students, Students.Length*2);
            }
        }

        public void Remove(String studentName)
        {
            
        }

        public void Graduate(String studentName)
        {

        }
    }
}
