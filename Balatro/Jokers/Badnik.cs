using System;
using System.Collections.Generic;
using System.Text;

namespace Balatro.Jokers
{
    public class Badnik : Joker
    {
        public Badnik() : base(
        "Бадник",
        "badnik",
        5,
        "Христор воскр-се роди!",
        "После секоја рунда, имаш 1/6 шанса да добиеш $30"
        )
        {
            this.AfterRound = true;
        }

        public override void Effect(Round round, Form1 form)
        {
            form.extramoney += 30;
        }

        public override bool Condition(Round round)
        {
            int num = rnd.Next(0, 6);
            return num == 0;
        }
    }
}
