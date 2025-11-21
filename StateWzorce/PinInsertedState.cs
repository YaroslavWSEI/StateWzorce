using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public class PinInsertedState : State
    {
        public PinInsertedState(ATMContext context) : base(context) { }

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
            Console.WriteLine("PIN został już wprowadzony.");
        }

        public override void WithdrawCash(int amount)
        {
            if (context.CashInMachine <= 0)
            {
                Console.WriteLine("Brak gotówki w bankomacie!");
                context.ChangeState(new NoCashState(context));
                return;
            }

            if (amount > context.CashInMachine)
            {
                Console.WriteLine("Niewystarczające środki w bankomacie.");
            }
            else
            {
                Console.WriteLine($"Wypłacono {amount} zł.");
                context.CashInMachine -= amount;

                if (context.CashInMachine == 0)
                {
                    Console.WriteLine("Bankomat jest teraz pusty!");
                    context.ChangeState(new NoCashState(context));
                }
                else
                {
                    context.ChangeState(new NoCardState(context));
                }
            }
        }
    }
}
