using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Zookeeper : IEnumerable
    {
        private AnimalCollection _animal;

        public Zookeeper(AnimalCollection animal)
        {
            _animal = animal;
        }

        public IEnumerator GetEnumerator()
        {
            return new AnimalEnumerator(_animal);
        }
    }
}
