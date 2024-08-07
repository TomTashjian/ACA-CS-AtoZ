﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class TrainTicket : IEnumerable
    {
        private List<TrainStation> _trainStations = new List<TrainStation>();
        private List<TrainStation> _cityZoneA = new List<TrainStation>() 
        {
            new TrainStation() { Name = "Zone A - Station A1" },
            new TrainStation() { Name = "Zone A - Station A2" },
            new TrainStation() { Name = "Zone A - Station A3" }
        };                                       
        private List<TrainStation> _cityZoneB = new List<TrainStation>() 
        {                                        
            new TrainStation() { Name = "Zone B - Station B1" },
            new TrainStation() { Name = "Zone B - Station B2" },
            new TrainStation() { Name = "Zone B - Station B3" }
        };                                       
        private List<TrainStation> _cityZoneC = new List<TrainStation>()
        {                                        
            new TrainStation() { Name = "Zone C - Station C1" },
            new TrainStation() { Name = "Zone C - Station C2" },
            new TrainStation() { Name = "Zone C - Station C3" }
        };

        public TrainTicket(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.Silver:
                    _trainStations.AddRange(_cityZoneA);
                    break;
                case TicketType.Gold:
                    _trainStations.AddRange(_cityZoneA);
                    _trainStations.AddRange(_cityZoneB);
                    break;
                case TicketType.Platinum:
                    _trainStations.AddRange(_cityZoneA);
                    _trainStations.AddRange(_cityZoneB);
                    _trainStations.AddRange(_cityZoneC);
                    break;
            }
        }

        public enum TicketType
        {
            Silver,
            Gold,
            Platinum
        }
        public IEnumerator GetEnumerator()
        {
            return new TrainRoute(_trainStations);
        }
    }
}
