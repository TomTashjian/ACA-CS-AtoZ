using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInfo
{
    internal class VisaCard : ICard
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int SubType { get; set; }
        public int CVV { get; set; }

        public CardDTO GetCardbyId(int id)
        {
            if(id == 1)
                return new CardDTO() { CardType = "Master"};
            else if(id == 2)
                return new CardDTO() { CardType = "Visa" };
        }
    }
}
