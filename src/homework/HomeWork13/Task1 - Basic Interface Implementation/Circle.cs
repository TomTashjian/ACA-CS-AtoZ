using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle : IShape
    {
        double pi = 3.14;
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return pi * Radius * Radius;
        }
    }
}
