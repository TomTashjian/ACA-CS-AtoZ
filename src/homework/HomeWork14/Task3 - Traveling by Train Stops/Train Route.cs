using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Train_Route : IEnumerator
    {
        private List<Train_Station> _trainStations = new List<Train_Station>();
        private int _currentIndex = -1;
        public Train_Route(List<Train_Station> trainStations) 
        {
            _trainStations = trainStations;
        }
        public object? Current { 
            get 
            {
                return _trainStations[_currentIndex];
            } 
        }

        public bool MoveNext()
        {
            if(_currentIndex >= (_trainStations.Count - 1))
            {
                return false;
            }
            else
            {
                _currentIndex++;
                return true;
            }
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
