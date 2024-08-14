using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class FibonacciSequence : IEnumerable
    {
        private int _limit { get; set; }

        public FibonacciSequence(int limit)
        {
            _limit = limit;
        }

        public IEnumerator GetEnumerator()
        {
            double a = 1;
            double b = 0;
            double seqItem = 0;
            for(int i = 0; i < _limit; i++)
            {
                seqItem = a + b;
                a = b;
                b = seqItem;
                yield return seqItem;
            }
        }
    }
}
