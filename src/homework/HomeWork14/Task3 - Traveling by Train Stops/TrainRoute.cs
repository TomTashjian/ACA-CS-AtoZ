using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class TrainRoute : IEnumerator
    {
        private List<TrainStation> _trainStations = new List<TrainStation>();
        private int _currentIndex = -1;
        public TrainRoute(List<TrainStation> trainStations) 
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
