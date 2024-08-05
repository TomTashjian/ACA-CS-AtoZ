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
            Train_Ticket.TicketType ticketType = Train_Ticket.TicketType.Platinum;

            Train_Ticket ticket = new Train_Ticket(ticketType);

            Console.WriteLine($"Here are the stations included in {ticketType} type ticket:");
            foreach (Train_Station station in ticket)
            {
                Console.WriteLine(station.Name);
            }
        }
    }
}
