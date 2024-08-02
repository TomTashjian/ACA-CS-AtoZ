using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AnimalCollection
    {
        public AnimalCollection? Next { get; set; }

        public string? Name { get; set; }

        public AnimalCollection Add(AnimalCollection animal)
        {
            return Next = animal;
        }
    }
}
