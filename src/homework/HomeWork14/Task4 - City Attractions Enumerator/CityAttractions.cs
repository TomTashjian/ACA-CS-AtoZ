using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class CityAttractions : IEnumerable<Attraction>
    {
        private List<Attraction> _attractions = new List<Attraction>()
        {
            new Attraction() { Name = "Colosseum", Description = "Ancient Roman amphitheater", Category = "Landmark" },
            new Attraction() { Name = "Pantheon", Description = "Ancient Roman temple", Category = "Landmark" },
            new Attraction() { Name = "Trevi Fountain", Description = "Baroque fountain", Category = "Landmark" },
            new Attraction() { Name = "Vatican Museums", Description = "Art museums", Category = "Museum" },
            new Attraction() { Name = "Roman Forum", Description = "Ancient Roman marketplace", Category = "Historical Site" }
        };

        public IEnumerator<Attraction> GetEnumerator()
        {
            return new AttractionEnumerator(_attractions);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class AttractionEnumerator : IEnumerator<Attraction>
    {
        private List<Attraction> _attractions = new List<Attraction>();
        private int _currentIndex = -1;

        public AttractionEnumerator(List<Attraction> attractions)
        {
            _attractions = attractions;
        }
        public Attraction Current
        {
            get
            {
                return _attractions[_currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _attractions.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

         public void Dispose()
        {
            // nothing to dispose
        }
    }
}
