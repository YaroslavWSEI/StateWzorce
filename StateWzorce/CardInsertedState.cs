using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public class CardInsertedState : State
    {
        public CardInsertedState(ATMContext context) : base(context) { }

        public override void InsertCard()
        {
            Console.WriteLine("Karta już jest włożona.");
        }

        public override void EjectCard()
        {
            Console.WriteLine("Karta została wyjęta.");
            context.ChangeState(new NoCardState(context));
        }

        public override void InsertPin(int pin)
        {
            if (pin == 1234)
            {
                Console.WriteLine("PIN poprawny.");
                context.ChangeState(new PinInsertedState(context));
            }
            else
            {
                Console.WriteLine("PIN niepoprawny!");
            }
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Musisz najpierw wprowadzić PIN.");
        }
    }
}
