using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Student : IStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student()
        {
            
        }
    }
}
