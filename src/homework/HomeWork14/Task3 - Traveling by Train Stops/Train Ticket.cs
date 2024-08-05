using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Train_Ticket : IEnumerable
    {
        private List<Train_Station> _trainStations = new List<Train_Station>();
        private List<Train_Station> _cityZoneA = new List<Train_Station>() 
        {
            new Train_Station() { Name = "Zone A - Station A1" },
            new Train_Station() { Name = "Zone A - Station A2" },
            new Train_Station() { Name = "Zone A - Station A3" }
        };                                       
        private List<Train_Station> _cityZoneB = new List<Train_Station>() 
        {                                        
            new Train_Station() { Name = "Zone B - Station B1" },
            new Train_Station() { Name = "Zone B - Station B2" },
            new Train_Station() { Name = "Zone B - Station B3" }
        };                                       
        private List<Train_Station> _cityZoneC = new List<Train_Station>()
        {                                        
            new Train_Station() { Name = "Zone C - Station C1" },
            new Train_Station() { Name = "Zone C - Station C2" },
            new Train_Station() { Name = "Zone C - Station C3" }
        };

        public Train_Ticket(TicketType ticketType)
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
            return new Train_Route(_trainStations);
        }
    }
}
