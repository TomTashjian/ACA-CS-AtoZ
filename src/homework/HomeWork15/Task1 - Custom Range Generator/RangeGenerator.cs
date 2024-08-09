using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class RangeGenerator : IEnumerable
    {
        private int _start { get; set; }
        private int _end { get; set; }

        public IEnumerator GetEnumerator()
        {
            for (int i = _start; i <= _end; i++)
            {
                yield return i;
            }
        }

        public RangeGenerator(int start, int end)
        {
            _start = start;
            _end = end;
        }
    }
}
