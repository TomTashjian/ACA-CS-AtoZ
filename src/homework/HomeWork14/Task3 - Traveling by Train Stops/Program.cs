/*
Traveling by Train Stops:
Consider a train route with multiple stops (attractions).
IEnumerable is your train ticket, allowing you to travel from one stop to the next.
At each station (iteration), you explore the surroundings (access details) without knowing the entire route upfront.
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainTicket.TicketType ticketType = TrainTicket.TicketType.Platinum;

            TrainTicket ticket = new TrainTicket(ticketType);

            Console.WriteLine($"Here are the stations included in {ticketType} type ticket:");
            foreach (TrainStation station in ticket)
            {
                Console.WriteLine(station.Name);
            }
        }
    }
}
