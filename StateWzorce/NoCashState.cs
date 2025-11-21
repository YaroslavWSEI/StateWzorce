using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public class NoCashState : State
    {
        public NoCashState(ATMContext context) : base(context) { }

        public override void InsertCard()
        {
            Console.WriteLine("Bankomat nie ma gotówki – nie można użyć karty.");
        }
        public override void EjectCard()
        {
            Console.WriteLine("Nie ma karty do wyjęcia.");
        }
        public override void InsertPin(int pin)
        {
            Console.WriteLine("Brak gotówki – nie można wprowadzić PIN-u.");
        }
        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Bankomat jest pusty.");
        }
    }
}
