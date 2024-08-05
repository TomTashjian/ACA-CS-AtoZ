using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Zookeeper : IEnumerator
    {
        private AnimalCollection? _animal;

        public object? Current{ get; private set; }

        public Zookeeper(AnimalCollection animal)
        {
            _animal = animal;
        }

        public bool MoveNext()
        {
            if (_animal == null)
            {
                return false;
            }
            else
            {
                Current = _animal;
                _animal = _animal.Next;
                return true;
            }
        }

        public void Reset()
        {
            _animal = null;
        }
    }
}
