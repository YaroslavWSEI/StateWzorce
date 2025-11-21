using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public class ATMContext
    {
        private State currentState;
        public int CashInMachine { get; set; }

        public ATMContext(int initialCash)
        {
            CashInMachine = initialCash;

            if (CashInMachine > 0)
                currentState = new NoCardState(this);
            else
                currentState = new NoCashState(this);
        }

        public void ChangeState(State newState)
        {
            currentState = newState;
        }

        public void InsertCard() => currentState.InsertCard();
        public void EjectCard() => currentState.EjectCard();
        public void InsertPin(int pin) => currentState.InsertPin(pin);
        public void WithdrawCash(int amount) => currentState.WithdrawCash(amount);
    }

}
