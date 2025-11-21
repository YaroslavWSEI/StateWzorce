using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public class NoCardState : State
    {
        public NoCardState(ATMContext context) : base(context) { }
        public override void InsertCard()
        {
            Console.WriteLine("Card I.");
            context.ChangeState(new CardInsertedState(context));
        }
        public override void EjectCard()
        {
            Console.WriteLine("Nie możesz wyjąć karty – żadna nie jest włożona.");
        }
        public override void InsertPin(int pin)
        {
            Console.WriteLine("Nie możesz wprowadzić PIN-u bez karty.");
        }
        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Nie możesz wypłacić gotówki – brak karty.");
        }
    }
}
