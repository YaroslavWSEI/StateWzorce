using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateWzorce
{
    public abstract class State
    {
        protected ATMContext context;
        protected State(ATMContext context)
        {
            this.context = context;
        }
        public abstract void InsertCard();
        public abstract void EjectCard();
        public abstract void InsertPin(int pin);
        public abstract void WithdrawCash(int amount);
    }
}
