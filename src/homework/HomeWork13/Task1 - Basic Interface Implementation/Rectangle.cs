using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Width * Length;
        }
    }
}
